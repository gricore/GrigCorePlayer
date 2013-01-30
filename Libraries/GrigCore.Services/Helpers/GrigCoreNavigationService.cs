using Microsoft.Practices.Prism.Regions;

namespace GrigCore.Services.Helpers
{
    public class GrigCoreNavigationService : IGrigCoreNavigationService
    {
        #region Ctor

        public GrigCoreNavigationService(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        #endregion

        #region Fields

        private readonly IRegionManager _regionManager;

        #endregion

        #region Methods

        public void NavigateTo(string fullName)
        {
            _regionManager.Regions["NavigationFrame"].RequestNavigate(fullName);
        }

        #endregion
    }
}
