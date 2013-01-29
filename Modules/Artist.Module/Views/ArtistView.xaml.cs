using Artist.Module.Models;
using Artist.Module.Presenters;
using Microsoft.Practices.Unity;

namespace Artist.Module.Views
{
    /// <summary>
    /// Interaction logic for ArtistView.xaml
    /// </summary>
    public partial class ArtistView : IArtistView
    {
        public ArtistView(IUnityContainer container)
        {
            InitializeComponent();
            DataContext = container.Resolve<IArtistPresenter>();
        }
    }
}
