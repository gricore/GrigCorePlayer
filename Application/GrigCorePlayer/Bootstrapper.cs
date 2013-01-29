using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.UnityExtensions;
using RootModule;

namespace GrigCorePlayer
{
    public class Bootstrapper : UnityBootstrapper
    {

        protected override System.Windows.DependencyObject CreateShell()
        {
            var shell = new Shell();
            shell.Show();
            return shell;
        }


        protected override IModuleCatalog CreateModuleCatalog()
        {
            var moduleRegistrator = new ModuleRegistrator();
            ModuleCatalog catalog = moduleRegistrator.GetRegisteredModules();

            return catalog;
        }

    }
}
