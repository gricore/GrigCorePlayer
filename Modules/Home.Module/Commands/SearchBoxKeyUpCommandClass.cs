using Artist.Module.Views;
using GrigCore.Models;
using GrigCore.Models.SentModels;
using Microsoft.Practices.Prism.Events;
using System;
using System.Windows.Input;
using GrigCore.Services.Helpers;
using Home.Module.Models;

namespace Home.Module.Commands
{
    public class SearchBoxKeyUpCommandClass : ISearchBoxKeyUpCommand, ICommand
    {
        #region Fields

        public event EventHandler CanExecuteChanged;
        public readonly IEventAggregator _eventAggregator;
        private readonly IGrigCoreNavigationService _grigCoreNavigationService;   

        #endregion

        #region Methods

        public bool CanExecute(object parameter)
        {
            // Check keyboard device, if entered key is 'Enter'
            // button, command can execute, else can not.

            var model = parameter as HomeModel;
            if (model == null)
                return false;

            if (string.IsNullOrWhiteSpace(model.SearchBoxText))
                return false;

            if (Keyboard.IsKeyDown(Key.Enter))
                return true;

            return false;
        }


        public void Execute(object parameter)
        {
            var model = parameter as HomeModel;
            if (model == null)
                return;

            if (!string.IsNullOrWhiteSpace(model.SearchBoxText))
            {
                _eventAggregator.GetEvent<SelectedArtistEvent>().Publish(new ArtistModel { Name = model.SearchBoxText });
                _grigCoreNavigationService.NavigateTo(typeof(ArtistView).FullName);
            }
        }

        #endregion

        #region Ctor

        public SearchBoxKeyUpCommandClass(IEventAggregator eventAggregator,
            IGrigCoreNavigationService grigCoreNavigationService)
        {
            _eventAggregator = eventAggregator;
            _grigCoreNavigationService = grigCoreNavigationService;           
        }

        #endregion
    }

    #region Interface

    public interface ISearchBoxKeyUpCommand
    {
    }

    #endregion
}
