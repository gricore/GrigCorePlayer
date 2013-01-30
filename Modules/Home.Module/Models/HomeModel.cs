using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.ViewModel;

namespace Home.Module.Models
{
    public class HomeModel : NotificationObject
    {
        private string _searchBoxText = "Enter artist name";

        public string SearchBoxText
        {
            get { return _searchBoxText; }
            set
            {
                if (_searchBoxText != null && _searchBoxText != value)
                {
                    _searchBoxText = value;
                    RaisePropertyChanged(() => SearchBoxText);
                }

            }
        }

    }
}
