using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;

namespace WaveFit.Classes
{
    /// <summary>
    /// Classe usada para cancelar uma seleção de um item da combobox
    /// </summary>
	public static class CancelComboBoxSelection
	{
        /// <summary>
        /// Cria uma dependency property para usar como confirmação do valor
        /// </summary>
		public static readonly DependencyProperty ConfirmationValueBindingProperty = DependencyProperty.RegisterAttached(
			"ConfirmationValueBinding", typeof(bool), typeof(CancelComboBoxSelection), new PropertyMetadata(false, OnConfirmationValueBindingChanged));

		public static bool GetConfirmationValueBinding(DependencyObject depObj)
		{
			return (bool) depObj.GetValue(ConfirmationValueBindingProperty);
		}

		public static void SetConfirmationValueBinding(DependencyObject depObj, bool value)
		{
			depObj.SetValue(ConfirmationValueBindingProperty, value);
		}

        /// <summary>
        /// Modifica qual o destino do evento de item selecionado na combobox
        /// </summary>
        /// <param name="depObj"></param>
        /// <param name="e"></param>
		private static void OnConfirmationValueBindingChanged(DependencyObject depObj, DependencyPropertyChangedEventArgs e)
		{
			if (depObj != null)
			{
				ComboBox comboBox = (ComboBox) depObj;

				if ((bool) e.NewValue)
				{
					comboBox.SelectionChanged -= ComboBox_SelectionChanged;
					comboBox.SelectionChanged += ComboBox_SelectionChanged;
				}
			}
		}

        /// <summary>
        /// Evento de novo item selecionado. Este evento altera antes o valor na fonte do binding e apenas depois atualiza o alvo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private static void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (sender != null)
			{
				ComboBox comboBox = (ComboBox) sender;
				BindingExpression bndExp;

				if ((bndExp = comboBox.GetBindingExpression(Selector.SelectedIndexProperty)) != null ||
					(bndExp = comboBox.GetBindingExpression(Selector.SelectedItemProperty)) != null)
				{
					bndExp.UpdateSource();
					bndExp.UpdateTarget();
				}
			}
		}
	}
}
