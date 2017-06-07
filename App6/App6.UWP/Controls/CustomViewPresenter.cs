using App6.UWP.Views;
using MvvmCross.Core.ViewModels;
using MvvmCross.Uwp.Views;

namespace App6.UWP.Controls
{
    public class CustomViewPresenter : MvxWindowsMultiRegionViewPresenter
    {
        private readonly IMvxWindowsFrame _rootFrame;

        public CustomViewPresenter(IMvxWindowsFrame rootFrame)
            : base(rootFrame)
        {
            _rootFrame = rootFrame;
        }

        public override void ChangePresentation(MvxPresentationHint hint)
        {
            if (hint is MvxPanelPopToRootPresentationHint)
            {
                var mainView = _rootFrame.Content as MainView;
                if (mainView != null)
                {
                    mainView.PopToRoot();
                }
            }

            base.ChangePresentation(hint);
        }
    }
}
