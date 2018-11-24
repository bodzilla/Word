using System.Security;

namespace Word.ViewModel.Base
{
    /// <summary>
    /// An interface for a class that can provide a secure password.
    /// </summary>
    public interface IHavePassword
    {
        /// <summary>
        /// The secure string.
        /// </summary>
        SecureString SecurePassword { get; }
    }
}
