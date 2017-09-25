using System;
using System.Windows.Markup;

namespace SeliseFileExplorer.Converter
{
    [MarkupExtensionReturnType(typeof(BaseConverter))]
    public abstract class BaseConverter : MarkupExtension
    {
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
    }
}