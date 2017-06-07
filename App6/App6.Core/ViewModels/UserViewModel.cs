using MvvmCross.Core.ViewModels;

namespace App6.Core.ViewModels
{
    public class UserViewModel : BaseViewModel
    {
        public IMvxCommand ResetTextCommand => new MvxCommand(ResetText);
        private void ResetText()
        {
            Text = "Hello Users";
        }

        private string _text = "Hello Users";
        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }
    }
}