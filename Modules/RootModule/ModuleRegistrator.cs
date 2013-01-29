using Artist.Module;
using Home.Module;
using Microsoft.Practices.Prism.Modularity;
using Navigation.Module;
using User.Module;

namespace RootModule
{
    public class ModuleRegistrator 
    {
        public ModuleCatalog GetRegisteredModules()
        {
            var catalog = new ModuleCatalog();
            catalog.AddModule(typeof(NavigationModule));
            catalog.AddModule(typeof(HomeModule));
            catalog.AddModule(typeof(ArtistModule));
            catalog.AddModule(typeof (UserModule));

            return catalog;
        }
    }
    
}
