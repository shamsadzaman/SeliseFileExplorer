using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;
using SeliseFileExplorer.Constants;

namespace SeliseFileExplorer.Converter
{
    [MarkupExtensionReturnType(typeof(FolderViewTypeToVisibleConverter))]
    public class FolderViewTypeToVisibleConverter : BaseConverter, IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is FolderViewType && parameter is FolderViewType)
            {
                var viewType = (FolderViewType) value;
                var folderViewType = (FolderViewType) parameter;

                if (viewType == folderViewType)
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
