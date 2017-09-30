using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using SeliseFileExplorer.Model;

namespace SeliseFileExplorer.Converter
{
    public class ThemeTypeToCollapsedConverter : BaseConverter, IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is ThemeId && parameter is ThemeId)
            {
                var themeId = (ThemeId) value;
                var targetThemeId = (ThemeId) parameter;
                if (themeId == targetThemeId)
                {
                    return Visibility.Visible;
                }
            }

            return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}