using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WaveFit.Classes
{
	/// <summary>
	/// Classe que implementa uma tarefa a ser realizada após um período, podendo este período ser reiniciado no meio da espera.
	/// </summary>
	class WatchdogScheduler
	{
		private int interval = 1000;
		private bool activated = false;
		private Action task = null;
		private Thread waitingThread = null;
		private Mutex mutex = null;

		/// <summary>
		/// Construtor da classe.
		/// </summary>
		public WatchdogScheduler()
		{
			mutex = new Mutex();
		}

		/// <summary>
		/// Construtor da classe.
		/// </summary>
		/// <param name="Interval">Intervalo em milissegundos a ser esperado antes da tarefa ser realizada.</param>
		public WatchdogScheduler(int Interval) : this()
		{
			interval = Interval;
		}

		/// <summary>
		/// Construtor da classe.
		/// </summary>
		/// <param name="Interval">Intervalo em milissegundos a ser esperado antes da tarefa ser realizada.</param>
		/// <param name="Task">Tarefa a ser realizada.</param>
		public WatchdogScheduler(int Interval, Action Task) : this(Interval)
		{
			task = Task;
		}

		/// <summary>
		/// Intervalo em milissegundos a ser esperado antes da tarefa ser realizada.
		/// </summary>
		public int Interval
		{
			get { return interval; }
			set
			{
				if (value <= 0) throw new ApplicationException("O intervalo deve ser maior do que zero.");

				Exception ex = null;

				mutex.WaitOne();
				{
					if (activated) ex = new InvalidOperationException("Não é possível alterar o intervalo enquanto o watchdog está ativado.");
					else interval = value;
				}
				mutex.ReleaseMutex();

				if (ex != null) throw ex;
			}
		}

		/// <summary>
		/// Informa se o watchdog está aguardando ou não para realizar a tarefa.
		/// </summary>
		public bool Activated
		{
			get
			{
				bool ret;

				mutex.WaitOne();
				ret = activated;
				mutex.ReleaseMutex();

				return ret;
			}
		}

		/// <summary>
		/// Tarefa a ser realizada.
		/// </summary>
		public Action Task
		{
			get { return task; }
			set
			{
				Exception ex = null;

				mutex.WaitOne();
				{
					if (activated) ex = new InvalidOperationException("Não é possível alterar a tarefa enquanto o watchdog está ativado.");
					else task = value;
				}
				mutex.ReleaseMutex();

				if (ex != null) throw ex;
			}
		}

		/// <summary>
		/// Reinicia o watchdog.
		/// </summary>
		public void Reset()
		{
			if (task == null) throw new InvalidOperationException("Não existe tarefa para ser executada.");

			mutex.WaitOne();
			{
				if (waitingThread != null && waitingThread.IsAlive)
					waitingThread.Abort();

				waitingThread = new Thread(Wait);
				waitingThread.Start();

				activated = true;
			}
			mutex.ReleaseMutex();
		}

		/// <summary>
		/// Processo de espera do watchdog.
		/// </summary>
		public void Wait()
		{
			Thread.Sleep(interval);

			mutex.WaitOne();
			{
				task.Invoke();
				activated = false;
			}
			mutex.ReleaseMutex();
		}

		/// <summary>
		/// Desativa o watchdog.
		/// </summary>
		public void Deactivate()
		{
			mutex.WaitOne();
			{
				if (activated)
				{
					if (waitingThread != null && waitingThread.IsAlive)
					{
						waitingThread.Abort();
						waitingThread = null;
					}

					activated = false;
				}
			}
			mutex.ReleaseMutex();
		}
	}
}
