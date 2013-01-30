using System;
using System.Windows.Input;
using GrigCore.Services.Helpers;
using Navigation.Module.Models;
using Home.Module.Views;

namespace Navigation.Module.Commands
{
    public class HomeClickCommandClass : INavigationCommand, ICommand
    {
        #region Fields
        
        private readonly IGrigCoreNavigationService _grigCoreNavigationService;
        public event EventHandler CanExecuteChanged;

        #endregion

        #region Ctor

        public HomeClickCommandClass(IGrigCoreNavigationService grigCoreNavigationService)
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
            _grigCoreNavigationService.NavigateTo(typeof(HomeView).FullName);
        }

        #endregion
    }

}
