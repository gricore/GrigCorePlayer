using GrigCore.Controls.Models;
using GrigCore.Controls.Views;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using Navigation.Module.Commands;
using Navigation.Module.Presenters;
using GrigCore.Controls.Presenters;
using Navigation.Module.Models;

namespace Navigation.Module
{
    public class NavigationModule : IModule
    {
        private readonly IRegionManager _regionManager;
        private readonly IUnityContainer _container;


        public NavigationModule(IRegionManager regionManager, IUnityContainer container)
        {
            _regionManager = regionManager;
            _container = container;
        }



        public void Initialize()
        {
            // Register presenter and view.
            _container.RegisterType<INavigationPanelPresenter, NavigationPanelPresenter>();
            _container.RegisterType<INavigationPanelView, NavigationPanelView>();

            // Register the "NavigationPanel" region.
            _regionManager.Regions["NavigationPanel"].Add(_container.Resolve<INavigationPanelView>());

            // Register commands for events handler.
            _container.RegisterType<INavigationCommand, HomeClickCommandClass>();
        }

    }
}
