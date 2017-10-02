using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;
using SeliseFileExplorer.Constants;

namespace SeliseFileExplorer.Converter
{
    [MarkupExtensionReturnType]
    public class ToolbarCommandTypeToImageSource : BaseConverter, IValueConverter
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
                    return "../Resource/Image/Delete.png";

                case ToolbarCommandType.ShowGridView:
                    return "../Resource/Image/TileView.png";

                case ToolbarCommandType.ShowListView:
                    return "../Resource/Image/ListView.png";

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