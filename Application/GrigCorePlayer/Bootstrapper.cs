using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.UnityExtensions;
using Microsoft.Practices.Unity;
using RootModule;

namespace GrigCorePlayer
{
    public class Bootstrapper : UnityBootstrapper
    {
        private IUnityContainer _container;

        protected override System.Windows.DependencyObject CreateShell()
        {
            var shell = new Shell();
            shell.Show();
            return shell;
        }

        protected override Microsoft.Practices.Unity.IUnityContainer CreateContainer()
        {
            return _container;
        }


        protected override IModuleCatalog CreateModuleCatalog()
        {
            _container = new UnityContainer();
            _container.RegisterType<IModuleRegistrator, ModuleRegistrator>();
            Container = _container;


            var moduleRegistrator = _container.Resolve<ModuleRegistrator>();
            ModuleCatalog catalog = moduleRegistrator.GetRegisteredModules();

            return catalog;
        }

    }
}
