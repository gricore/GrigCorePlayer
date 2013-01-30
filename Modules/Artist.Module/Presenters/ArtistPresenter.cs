using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Microsoft.Practices.Unity;
using Artist.Module.Commands;

namespace Artist.Module.Presenters
{
    public partial class ArtistPresenter : IArtistPresenter
    {
        #region Command
        public ICommand ArtistViewLoadedCommand { get; private set; }
        #endregion

        #region Fields
        private readonly IUnityContainer _container;
        #endregion

        public ArtistPresenter(IUnityContainer container)
        {
            _container = container;
            ArtistViewLoadedCommand = _container.Resolve<ArtistViewLoadedCommandClass>();
        }
    }

    public interface IArtistPresenter
    {

    }
}
