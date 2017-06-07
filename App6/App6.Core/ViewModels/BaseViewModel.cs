using System.Windows.Input;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;

namespace App6.Core.ViewModels
{
    /// <summary>
    ///    Defines the BaseViewModel type.
    /// </summary>
    public abstract class BaseViewModel : MvxViewModel
    {
        protected IMvxNavigationService NavigationService { get; } = Mvx.Resolve<IMvxNavigationService>();

        /// <summary>
        /// Gets the almanac go back command.
        /// </summary>
        /// <value>
        /// The almanac go back command.
        /// </value>
        public virtual ICommand GoBackCommand
        {
            get
            {
                return new MvxCommand(() => Close(this));
            }
        }
    }
}
