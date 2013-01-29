using Home.Module.Models;
using Home.Module.Presenters;
using Microsoft.Practices.Unity;

namespace Home.Module.Views
{
    /// <summary>
    /// Interaction logic for HomeView.xaml
    /// </summary>
    public partial class HomeView : IHomeView
    {
        public HomeView(IUnityContainer container)
        {
            InitializeComponent();
            DataContext = container.Resolve<IHomePresenter>();
        }
    }
}
