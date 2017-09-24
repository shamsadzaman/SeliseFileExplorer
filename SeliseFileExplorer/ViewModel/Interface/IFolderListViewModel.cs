using System.Collections.Generic;
using SeliseFileExplorer.Model;

namespace SeliseFileExplorer.ViewModel.Interface
{
    public interface IFolderListViewModel
    {
        IList<Folder> FolderList { get; set; }
    }
}