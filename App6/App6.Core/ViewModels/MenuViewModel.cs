using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;

namespace App6.Core.ViewModels
{
    public class MenuViewModel : BaseViewModel
    {
        private readonly MvxPresentationHint _popToRootHint = Mvx.Resolve<MvxPresentationHint>();
        private IMvxAsyncCommand _showHomeCommand;
        private IMvxAsyncCommand _showUsersCommand;
        private IMvxAsyncCommand _showCurrentUserCommand;

        public IMvxCommand PopToRootCommand
        {
            get
            {
                return new MvxCommand(() =>
                {
                    ChangePresentation(_popToRootHint);
                });
            }
        }

        public IMvxAsyncCommand ShowHomeCommand
        {
            get
            {
                _showHomeCommand = _showHomeCommand ?? new MvxAsyncCommand(() => NavigationService.Navigate<HomeViewModel>());
                return _showHomeCommand;
            }
        }

        public IMvxAsyncCommand ShowUsersCommand
        {
            get
            {
                _showUsersCommand = _showUsersCommand ?? new MvxAsyncCommand(() => NavigationService.Navigate<UserViewModel>());
                return _showUsersCommand;
            }
        }

        public IMvxAsyncCommand ShowCurrentUserCommand
        {
            get
            {
                _showCurrentUserCommand = _showCurrentUserCommand ?? new MvxAsyncCommand(() => NavigationService.Navigate<UserViewModel>());
                return _showCurrentUserCommand;
            }
        }
    }
}
