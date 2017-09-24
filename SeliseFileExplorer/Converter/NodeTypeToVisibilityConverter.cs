using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;
using SeliseFileExplorer.Constants;

namespace SeliseFileExplorer.Converter
{
    [MarkupExtensionReturnType(typeof(NodeTypeToVisibilityConverter))]
    public class NodeTypeToVisibilityConverter : MarkupExtension, IValueConverter
    {
        private static readonly NodeTypeToVisibilityConverter Instance = new NodeTypeToVisibilityConverter();

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return Instance;
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is NodeType) || !(parameter is NodeType))
            {
                return Visibility.Collapsed;
            }

            var nodeType = (NodeType) value;
            var targetNodeType = (NodeType) parameter;

            if (nodeType == targetNodeType)
            {
                return Visibility.Visible;
            }

            return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}