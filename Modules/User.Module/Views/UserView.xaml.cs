using Microsoft.Practices.Unity;
using User.Module.Presenters;
using User.Module.Models;
namespace User.Module.Views
{
    /// <summary>
    /// Interaction logic for UserView.xaml
    /// </summary>
    public partial class UserView : IUserView
    {
        public UserView(IUnityContainer container)
        {
            InitializeComponent();
            DataContext = container.Resolve<IUserPresenter>();
        }
    }
}
