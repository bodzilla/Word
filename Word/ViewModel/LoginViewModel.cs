using System.Security;
using System.Threading.Tasks;
using System.Windows.Input;
using Word.Security;
using Word.ViewModel.Base;

namespace Word.ViewModel
{
    /// <summary>
    /// View Model for a login screen.
    /// </summary>
    public class LoginViewModel : BaseViewModel
    {
        #region Public Properties

        /// <summary>
        /// The email of the user.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The user's password.
        /// </summary>
        public SecureString Password { get; set; }

        /// <summary>
        /// A flag indicating that the login process is running.
        /// </summary>
        public bool LoginIsRunning { get; set; }

        #endregion

        #region Commands

        /// <summary>
        /// The command to login.
        /// </summary>
        public ICommand LoginCommand { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public LoginViewModel() => LoginCommand = new RelayParameterizedCommand(async parameter => await Login(parameter));

        #endregion

        /// <summary>
        /// Attempts to log the user in.
        /// </summary>
        /// <param name="parameter">The <see cref="SecureString"/> passed in from the view for the user's password</param>
        /// <returns></returns>
        public async Task Login(object parameter)
        {
            await RunCommand(() => LoginIsRunning, async () =>
                {
                    await Task.Delay(5000);
                    var email = Email;
                    var password = (parameter as IHavePassword)?.SecurePassword.Unsecure();
                });
        }
    }
}
