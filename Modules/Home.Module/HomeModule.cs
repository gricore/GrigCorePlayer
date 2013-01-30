using System;
using GrigCore.Services.Helpers;
using Home.Module.Presenters;
using Home.Module.Views;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Prism.Regions;
using Home.Module.Commands;

namespace Home.Module
{
    public class HomeModule : IModule
    {
        private readonly IUnityContainer _container;
        private readonly IRegionManager _regionManager;
        private readonly IGrigCoreNavigationService _grigCoreNavigationService;


        public HomeModule(IUnityContainer container, IRegionManager regionManager,
            IGrigCoreNavigationService grigCoreNavigationService)
        {
            _container = container;
            _regionManager = regionManager;
            _grigCoreNavigationService = grigCoreNavigationService;
        }


        public void Initialize()
        {
            // This operator register Presenter for set it 
            // as data context on view loader method.
            _container.RegisterType<IHomePresenter, HomePresenter>();

            // This operator, register View for navigation name.         
            _container.RegisterType<Object, HomeView>(typeof(HomeView).FullName);

            // Navigate to 'Home' page, beacouse it's
            // need to load by default
            _grigCoreNavigationService.NavigateTo(typeof(HomeView).FullName);

            // Register commands
            _container.RegisterType<ISearchBoxKeyUpCommand, SearchBoxKeyUpCommandClass>();
        }
    }
}
