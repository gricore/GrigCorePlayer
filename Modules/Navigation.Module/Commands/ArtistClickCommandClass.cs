using System;
using System.Windows.Input;
using Artist.Module.Views;
using Navigation.Module.Models;
using GrigCore.Services.Helpers;

namespace Navigation.Module.Commands
{
    public class ArtistClickCommandClass : INavigationCommand, ICommand
    {
        #region Fields

        private readonly IGrigCoreNavigationService _grigCoreNavigationService;
        public event EventHandler CanExecuteChanged;

        #endregion

        #region Ctor

        public ArtistClickCommandClass(IGrigCoreNavigationService grigCoreNavigationService)
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
            _grigCoreNavigationService.NavigateTo(typeof(ArtistView).FullName);
        }

        #endregion
    }
}
