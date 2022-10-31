using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.Models;

namespace Teste.ViewModels
{
    internal class ShellViewModel:Conductor<object>
    {
		private  string _firstName;
        private string _lastName;
		private PersonModel _selectedPerson;
        private BindableCollection<PersonModel> _people = new BindableCollection<PersonModel>();
	
		public ShellViewModel()
		{
			People.Add(new PersonModel { FirstName = "Angelo", LastName = "Lara" });
            People.Add(new PersonModel { FirstName = "Victoria", LastName = "Lara" });
            People.Add(new PersonModel { FirstName = "Joao", LastName = "Lara" });
        }

        public string FirstName
		{
			get 
			{ 
				return _firstName; 
			}
			set 
			{ 
				_firstName = value;
				NotifyOfPropertyChange(() => FirstName);
			}
		}
		
		public string LastName
		{
			get 
			{ 
				return _lastName; 
			}
			set 
			{
				_lastName = value; 
				NotifyOfPropertyChange(() => LastName);
                NotifyOfPropertyChange(() => FullName);
            }
		}
		
		public string FullName
		{
			get 
			{ 
				return $"{_firstName} {_lastName}";
			}
		}
        
		public PersonModel SelectedPerson
        {
            get { return _selectedPerson; }
            set { _selectedPerson = value; NotifyOfPropertyChange(() => SelectedPerson); }
        }
        
		public BindableCollection<PersonModel> People
		{
			get { return _people; }
			set { _people = value; }
		}
        
		public bool CanClearText(string firstName, string lastName)
		{
			if(String.IsNullOrEmpty(firstName) && String.IsNullOrEmpty(lastName))
			{
				return false;
			}
			else
			{
				return true;
			}
		}

        public void ClearText(string firstName, string lastName)
		{
			FirstName = "";
			LastName = "";
		}

		public void LoadPageOne()
		{
			ActivateItemAsync(new FirstChildViewModel());
		}

		public void LoadPageTwo()
		{
			ActivateItemAsync(new SecondChildViewModel());
		}

        public void OpenMainWindow()
        {
			LoginWindowViewModel login = new LoginWindowViewModel();
			login.Show();
        }
    }
}
