using System.Threading.Tasks;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;

namespace App6.Core.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public void ShowMenu()
        {
            Mvx.Resolve<IMvxNavigationService>().Navigate<HomeViewModel>();
            Mvx.Resolve<IMvxNavigationService>().Navigate<MenuViewModel>();
        }
    }
}