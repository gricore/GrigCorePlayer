using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Home.Module.Models;
using System.Windows.Input;
using Microsoft.Practices.Unity;
using Home.Module.Commands;

namespace Home.Module.Presenters
{
    public partial class HomePresenter : IHomePresenter
    {
        private string _someText = "Enter something";

        public string SomeText
        {
            get { return _someText; }
            set { _someText = value; }
        }
        

        #region Fields

        private readonly IUnityContainer _container;

        #endregion

        #region Commands

        public ICommand SearchBoxKeyUpCommand { get; private set; }

        #endregion

        #region Ctor

        public HomePresenter(IUnityContainer container)
        {
            // Get values from Unity container here.
            _container = container;

            // Commands setted from XAML code, after
            // set command execute value here.
            SearchBoxKeyUpCommand = _container.Resolve<SearchBoxKeyUpCommandClass>();
        }

        #endregion
    }

    public interface IHomePresenter
    {

    }
}
