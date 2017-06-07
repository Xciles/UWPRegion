using System.Windows.Input;
using Windows.UI.Xaml.Controls;

namespace App6.UWP.Controls
{
    public abstract class MenuItemBase
    {
        public ICommand Command { get; set; }
        public object Parameters { get; set; }
        
    }

    /// <summary>
    /// Data to represent an item in the nav menu.
    /// </summary>
    public class NavMenuItem : MenuItemBase
    {
        public string Label { get; set; }
        public Symbol Symbol { get; set; }

        public char SymbolAsChar
        {
            get { return (char) Symbol; }
        }
    }

    /// <summary>
    /// Data to represent an item in the nav menu.
    /// </summary>
    public class CurrentUserMenuItem : MenuItemBase
    {
        public CurrentUserMenuItem()
        {
        }
    }
}