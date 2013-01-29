using GrigCore.Controls.Models;
using Microsoft.Practices.Unity;
using GrigCore.Controls.Presenters;

namespace GrigCore.Controls.Views
{
    /// <summary>
    /// Interaction logic for NavigationPanelView.xaml
    /// </summary>
    public partial class NavigationPanelView : INavigationPanelView
    {

        public NavigationPanelView(IUnityContainer container)
        {
            InitializeComponent();
            DataContext = container.Resolve<INavigationPanelPresenter>();


        }


    }
}
