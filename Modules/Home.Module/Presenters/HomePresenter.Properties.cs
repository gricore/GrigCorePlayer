using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Home.Module.Models;

namespace Home.Module.Presenters
{
    public partial class HomePresenter
    {
        #region Properties

        private HomeModel _model = new HomeModel();
        /// <summary>
        /// Gets or sets HomeModel.
        /// </summary>
        public HomeModel Model
        {
            get { return _model; }
            set { _model = value; }
        }

        #endregion
    }
}
