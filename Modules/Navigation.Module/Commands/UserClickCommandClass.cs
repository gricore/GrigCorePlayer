using System;
using System.Windows.Input;
using Microsoft.Practices.Prism.Regions;
using Navigation.Module.Models;
using User.Module.Views;

namespace Navigation.Module.Commands
{
    public class UserClickCommandClass : INavigationCommand, ICommand
    {
        #region Fields

        private readonly IRegionManager _regionManager;
        public event EventHandler CanExecuteChanged;

        #endregion

        #region Ctor

        public UserClickCommandClass(IRegionManager regionManager)
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
            _regionManager.Regions["NavigationFrame"].RequestNavigate(typeof(UserView).FullName);
        }

        #endregion
    }

}
