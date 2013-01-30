using Artist.Module;
using GrigCore.Services.Helpers;
using Home.Module;
using Microsoft.Practices.Prism.Modularity;
using Navigation.Module;
using User.Module;
using Microsoft.Practices.Unity;

namespace RootModule
{
    public class ModuleRegistrator : IModuleRegistrator
    {
        private IUnityContainer _container;

        public ModuleRegistrator(IUnityContainer container)
        {
            _container = container;
        }

        public ModuleCatalog GetRegisteredModules()
        {
            // Register services before loading catalogs and regions
            ServicesRegistrator();

            var catalog = new ModuleCatalog();
            catalog.AddModule(typeof(NavigationModule));
            catalog.AddModule(typeof(HomeModule));
            catalog.AddModule(typeof(ArtistModule));
            catalog.AddModule(typeof(UserModule));

            return catalog;
        }


        public void ServicesRegistrator()
        {
            _container.RegisterType<IGrigCoreNavigationService, GrigCoreNavigationService>();            
        }


    }

    public interface IModuleRegistrator
    {
        ModuleCatalog GetRegisteredModules();
    }

}
