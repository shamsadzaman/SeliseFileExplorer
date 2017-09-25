using System.Collections.Generic;
using System.Windows.Documents;
using SeliseFileExplorer.Command;

namespace SeliseFileExplorer.ViewModel.Interface
{
    public interface IToolBarViewModel
    {
        List<ToolbarCommandViewModel> ToolbarCommandList { get; set; }
    }
}