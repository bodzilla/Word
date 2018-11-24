using System;
using System.Globalization;
using Word.DataModels;
using Word.Pages;

namespace Word.ValueConverters
{
    /// <inheritdoc />
    /// <summary>
    /// Converts the <see cref="T:Word.DataModels.ApplicationPage" /> to an actual view page.
    /// </summary>
    public class ApplicationPageValueConverter : BaseValueConverters<ApplicationPageValueConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return null;

            // Run the appropriate page.
            switch ((ApplicationPage)value)
            {
                case ApplicationPage.Login:
                    return new LoginPage();

                case ApplicationPage.Chat:
                    return new ChatPage();

                default:
                    throw new ArgumentOutOfRangeException(nameof(value), value, null);
            }
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
