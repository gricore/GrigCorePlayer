using System;
using Artist.Module.Models;
using GrigCore.Models;
using GrigCore.Models.SentModels;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Unity;
using Artist.Module.Views;
using Artist.Module.Presenters;
using Microsoft.Practices.Prism.Events;
using Artist.Module.Commands;

namespace Artist.Module
{
    public class ArtistModule : IModule
    {
        private readonly IUnityContainer _container;

        public ArtistModule(IUnityContainer container)
        {
            _container = container;
        }

        public void Initialize()
        {
            // Register Artist View, Presenter
            _container.RegisterType<IArtistView, ArtistView>();
            _container.RegisterType<IArtistPresenter, ArtistPresenter>();

            // Register for navigation
            _container.RegisterType<Object, ArtistView>(typeof(ArtistView).FullName);

            // Register commands
            _container.RegisterType<IArtistViewLoadedCommand, ArtistViewLoadedCommandClass>();
        }

    }
}
