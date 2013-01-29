using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Unity;
using User.Module.Presenters;
using System;
using User.Module.Views;
using User.Module.Models;

namespace User.Module
{
    public class UserModule : IModule
    {
        private readonly IUnityContainer _container;

        public UserModule(IUnityContainer container)
        {
            _container = container;
        }

        public void Initialize()
        {
            // Register user presenter.            
            _container.RegisterType<IUserView, UserView>();
            _container.RegisterType<IUserPresenter, UserPresenter>();

            // Register view object
            _container.RegisterType<Object, UserView>(typeof(UserView).FullName);
        }
    }
}
