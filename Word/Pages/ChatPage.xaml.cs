using System.Security;
using Word.ViewModel;
using Word.ViewModel.Base;

namespace Word.Pages
{
    /// <inheritdoc cref="BaseViewModel" />
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : BasePage<LoginViewModel>, IHavePassword
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        /// <inheritdoc />
        /// <summary>
        /// The secure password for this login page.
        /// </summary>
        public SecureString SecurePassword => PasswordText.SecurePassword;
    }
}
