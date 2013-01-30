using System;
using System.Windows.Input;
using GrigCore.Services.Helpers;
using Navigation.Module.Models;
using User.Module.Views;

namespace Navigation.Module.Commands
{
    public class UserClickCommandClass : INavigationCommand, ICommand
    {
        #region Fields

        public event EventHandler CanExecuteChanged;
        private readonly IGrigCoreNavigationService _grigCoreNavigationService;

        #endregion

        #region Ctor

        public UserClickCommandClass(IGrigCoreNavigationService grigCoreNavigationService)
        {
            _grigCoreNavigationService = grigCoreNavigationService;
        }

        #endregion

        #region Methods

        public bool CanExecute(object parameter)
        {
            return true;
        }


        public void Execute(object parameter)
        {
            _grigCoreNavigationService.NavigateTo(typeof(UserView).FullName);
        }

        #endregion
    }

}
