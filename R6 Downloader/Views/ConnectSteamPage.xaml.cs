using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace R6_Downloader.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ConnectSteamPage : Page
    {
        public static TextBox _usernameTB;
        public static PasswordBox passwordPB;
        public ConnectSteamPage()
        {
            this.InitializeComponent();
            _usernameTB = usernameTB;
            passwordPB = passwordBox;
        }

        private void revealPasswordBox_Changed(object sender, RoutedEventArgs e)
        {
            if (revealPasswordBox.IsChecked == true)
            {
                passwordBox.PasswordRevealMode = PasswordRevealMode.Visible;
            }
            else
            {
                passwordBox.PasswordRevealMode = PasswordRevealMode.Hidden;
            }
        }




    }
}
