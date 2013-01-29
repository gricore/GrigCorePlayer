using System;
using System.Windows.Input;
using Artist.Module.Views;
using Microsoft.Practices.Prism.Regions;
using Navigation.Module.Models;

namespace Navigation.Module.Commands
{
    public class ArtistClickCommandClass : INavigationCommand, ICommand
    {
        #region Fields

        private readonly IRegionManager _regionManager;
        public event EventHandler CanExecuteChanged;

        #endregion

        #region Ctor

        public ArtistClickCommandClass(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        #endregion

        #region Methods

        public bool CanExecute(object parameter)
        {
            return true;
        }



        public void Execute(object parameter)
        {
            _regionManager.Regions["NavigationFrame"].RequestNavigate(typeof(ArtistView).FullName);
        }

        #endregion
    }   
}
