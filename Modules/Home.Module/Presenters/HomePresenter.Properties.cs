using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Home.Module.Models;
using Microsoft.Practices.Prism.ViewModel;

namespace Home.Module.Presenters
{
    public partial class HomePresenter : NotificationObject
    {
        #region Properties

        private HomeModel _model = new HomeModel();
        /// <summary>
        /// Gets or sets HomeModel.
        /// </summary>
        public HomeModel Model
        {
            get { return _model; }
            set
            {
                if (_model != value)
                {
                    _model = value;
                    RaisePropertyChanged(() => Model);
                }

            }
        }

        #endregion
    }
}
