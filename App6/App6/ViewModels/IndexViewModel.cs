using App6.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App6.ViewModels
{
    class IndexViewModel : BaseViewModel
    {
        Command _goToProfileViewCommand;
        Command _goToRootCommand;

        public IndexViewModel(INavigation navigation = null) : base(navigation)
        {

        }

        public Command GoToProfile
        {
            get => _goToProfileViewCommand ?? (_goToProfileViewCommand = new Command(GoToProfileAction));
        }

        public Command GoToRoot
        {
            get => _goToRootCommand ?? (_goToRootCommand = new Command( () => Navigation.PopToRootAsync() ) );
        }

        private void GoToProfileAction()
        {
            Navigation.PushAsync(new Profile());
        }
    }
}
