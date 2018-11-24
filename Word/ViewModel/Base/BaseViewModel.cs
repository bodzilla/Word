using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using PropertyChanged;
using Word.Annotations;
using Word.Expressions;

namespace Word.ViewModel.Base
{
    [AddINotifyPropertyChangedInterface]
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// This event is fired when any child property changes its value.
        /// </summary>
        /// <param name="propertyName"></param>
        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #region Command Helpers

        /// <summary>
        /// Runs a command if the updating flag is not set.
        /// If the flag is true, then function is already running, the do not run the action.
        /// Else, then run the action.
        /// Once the action is finished (if it was finished running), then the flag is reset to false.
        /// </summary>
        /// <param name="updatingFlag">A bool flag defining if the command is already running.</param>
        /// <param name="action">The action to run if the command is not already running.</param>
        /// <returns></returns>
        protected async Task RunCommand(Expression<Func<bool>> updatingFlag, Func<Task> action)
        {
            // Check if the flag property is true (meaning the function is already running).
            if (updatingFlag.GetPropertyValue()) return;

            // Set the property flag to true to indicate we are running.
            updatingFlag.SetPropertyValue(true);

            try
            {
                // Run the passed in action.
                await action();
            }
            finally
            {
                // Set the property flag back to false now it's finished.
                updatingFlag.SetPropertyValue(false);
            }
        }

        #endregion
    }
}
