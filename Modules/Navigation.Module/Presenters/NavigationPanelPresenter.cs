using Microsoft.Practices.Unity;
using GrigCore.Controls.Presenters;
using System.Windows.Input;
using Navigation.Module.Commands;

namespace Navigation.Module.Presenters
{
    public class NavigationPanelPresenter : INavigationPanelPresenter
    {
        public ICommand HomeClickCommand { get; private set; }
        public ICommand ArtistClickCommand { get; private set; }
        public ICommand UserClickCommand { get; private set; }

        public NavigationPanelPresenter(IUnityContainer container)
        {
            HomeClickCommand = container.Resolve<HomeClickCommandClass>();
            ArtistClickCommand = container.Resolve<ArtistClickCommandClass>();
            UserClickCommand = container.Resolve<UserClickCommandClass>();
        }
    }




}
