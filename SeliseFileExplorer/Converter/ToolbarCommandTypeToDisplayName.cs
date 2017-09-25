using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;
using SeliseFileExplorer.Constants;

namespace SeliseFileExplorer.Converter
{
    [MarkupExtensionReturnType(typeof(ToolbarCommandTypeToDisplayName))]
    public class ToolbarCommandTypeToDisplayName : BaseConverter, IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is ToolbarCommandType))
            {
                return "";
            }

            var commandType = (ToolbarCommandType) value;

            switch (commandType)
            {
                case ToolbarCommandType.Delete:
                    return "Delete";

                case ToolbarCommandType.ShowGridView:
                    return "Grid View";

                case ToolbarCommandType.ShowListView:
                    return "List View";

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}