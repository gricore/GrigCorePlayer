using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using GrigCore.Models;
using Microsoft.Practices.Prism.Events;
using GrigCore.Models.SentModels;

namespace Artist.Module.Commands
{
    public class ArtistViewLoadedCommandClass : IArtistViewLoadedCommand, ICommand
    {
        private readonly IEventAggregator _eventAggregator;

        #region Fields
        public event EventHandler CanExecuteChanged;
        #endregion

        #region Methods
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _eventAggregator.GetEvent<SelectedArtistEvent>().Subscribe(OnArtistSelectedInSearchBox);
        }

        private void OnArtistSelectedInSearchBox(ArtistModel obj)
        {
            System.Windows.MessageBox.Show(obj.Name);
        }

        #endregion

        #region Ctor

        public ArtistViewLoadedCommandClass(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
        }

        #endregion
    }

    public interface IArtistViewLoadedCommand
    {

    }
}
