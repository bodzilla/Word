using System;
using System.Windows.Input;

namespace Word.ViewModel.Base
{
    /// <inheritdoc />
    /// <summary>
    /// A basic command that runs an Action.
    /// </summary>
    public class RelayCommand : ICommand
    {
        #region Private Members

        /// <summary>
        /// The action to run
        /// </summary>
        private readonly Action _action;

        #endregion

        #region Public Events

        /// <inheritdoc />
        /// <summary>
        /// The event thats fired when the <see cref="M:Word.ViewModel.Base.RelayCommand.CanExecute(System.Object)" /> value has changed.
        /// </summary>
        public event EventHandler CanExecuteChanged = (sender, e) => { };

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public RelayCommand(Action action) => _action = action;

        #endregion

        #region Command Methods

        /// <inheritdoc />
        /// <summary>
        /// A relay command can always execute.
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter) => true;

        /// <inheritdoc />
        /// <summary>
        /// Executes the command's Action.
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter) => _action();

        #endregion
    }
}
