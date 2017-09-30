using System.Collections.Generic;
using System.Windows.Documents;
using SeliseFileExplorer.Model;

namespace SeliseFileExplorer.ViewModel.Interface
{
    public interface IHeaderViewModel
    {
        string LogoImageLocation { get; set; }

        string HeaderTitle { get; set; }

        List<Theme> ThemeList { get; set; }
    }
}