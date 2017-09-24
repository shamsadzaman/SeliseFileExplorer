using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;
using SeliseFileExplorer.Constants;

namespace SeliseFileExplorer.Converter
{
    [MarkupExtensionReturnType(typeof(DirectoryContentTypeToVisibleConverter))]
    class DirectoryContentTypeToVisibleConverter : MarkupExtension, IValueConverter
    {
        public DirectoryContentTypeToVisibleConverter()
        {
        }

        private static readonly DirectoryContentTypeToVisibleConverter Instance = new DirectoryContentTypeToVisibleConverter();

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return Instance;
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var type = value as DirectoryContentType?;

            if (type == DirectoryContentType.File)
            {
                return Visibility.Collapsed;
            }

            return Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
