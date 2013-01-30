using Microsoft.Practices.Prism.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrigCore.Models
{
    public class ArtistModel : NotificationObject
    {
        private string _name = string.Empty;
        /// <summary>
        /// Gets or sets artist name.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    RaisePropertyChanged(() => Name);
                }
            }
        }

    }
}
