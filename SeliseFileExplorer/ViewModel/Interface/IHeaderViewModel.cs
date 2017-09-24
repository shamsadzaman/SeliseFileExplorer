using System.Collections.Generic;
using System.Windows.Documents;

namespace SeliseFileExplorer.ViewModel.Interface
{
    public interface IHeaderViewModel
    {
        string LogoImageLocation { get; set; }

        string HeaderTitle { get; set; }

        List<string> ThemeList { get; set; }
    }
}