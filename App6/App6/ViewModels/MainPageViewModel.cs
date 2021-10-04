using App6.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App6.ViewModels
{
    class MainPageViewModel : BaseViewModel
    {
        Command _goToViewIndexCommand;
        
        string _correo;
        string _password;
        bool _isErrorLogin;

        public MainPageViewModel(INavigation navigation = null) : base(navigation)
        {

        }

        public string Correo
        {
            get => _correo;
            set
            {
                if (string.Equals(_correo, value)) return;
                _correo = value;
                OnPropertyChanged();
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                if (string.Equals(_password, value)) return;
                _password = value;
                OnPropertyChanged();
            }
        }

        public bool IsErrorLogin
        {
            get => _isErrorLogin;
            set
            {
                _isErrorLogin = value;
                OnPropertyChanged();
            }
        }

        public Command GoToViewIndex
        {
            get => _goToViewIndexCommand ?? (_goToViewIndexCommand = new Command(GoToViewTwoAction));
        }
       
        private void GoToViewTwoAction()
        {
            IsErrorLogin = !(string.Equals(Correo, "ale.m.ascencio@hotmail.com") && string.Equals(Password, "aleale31"));

            if(!IsErrorLogin)
            {
                Correo = string.Empty;
                Password = string.Empty;
                Navigation.PushAsync(new Index());
            }
        }
    }
}
