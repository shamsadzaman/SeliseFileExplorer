using System.Collections.Generic;
using SeliseFileExplorer.Model;

namespace SeliseFileExplorer.ViewModel.Interface
{
    public interface IFolderListViewModel
    {
        List<Folder> FolderList { get; set; }
    }
}