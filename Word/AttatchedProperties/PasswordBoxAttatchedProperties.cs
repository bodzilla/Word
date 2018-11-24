using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using Word.ValueConverters;

namespace Word.AttatchedProperties
{
    /// <summary>
    /// The MonitorPassword attached property for a <see cref="PasswordBox"/>
    /// </summary>
    public class MonitorPasswordProperty : BaseAttachedProperty<MonitorPasswordProperty, bool>
    {
        public override void OnValueChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            // Get the caller and make sure it's a PasswordBox.
            var passwordBox = sender as PasswordBox;
            if (passwordBox == null) return;

            // Remove any previous events.
            passwordBox.PasswordChanged -= PasswordBox_PasswordChanged;

            // If the caller set the MonitorPassword.
            if ((bool)e.NewValue)
            {
                // Set default value.
                HasTextProperty.SetValue(passwordBox);

                // Listen out for password changed.
                passwordBox.PasswordChanged += PasswordBox_PasswordChanged;
            }
        }

        /// <summary>
        /// Fired when the PasswordBox value changes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e) => HasTextProperty.SetValue((PasswordBox)sender);
    }

    /// <summary>
    /// The HasText attached property for a <see cref="PasswordBox"/>
    /// </summary>
    public class HasTextProperty : BaseAttachedProperty<HasTextProperty, bool>
    {
        /// <summary>
        /// Sets the HasText property based on if the caller <see cref="PasswordBox"/> has any text.
        /// </summary>
        /// <param name="sender"></param>
        public static void SetValue(DependencyObject sender) => SetValue(sender, ((PasswordBox)sender).SecurePassword.Length > 0);
    }
}
