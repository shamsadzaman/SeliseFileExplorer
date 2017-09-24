using System.Collections.Generic;
using System.IO;
using System.Linq;
using SeliseFileExplorer.Constants;
using SeliseFileExplorer.Model;
using SeliseFileExplorer.ViewModel.Interface;
using Directory = SeliseFileExplorer.Model.Directory;

namespace SeliseFileExplorer.ViewModel
{
    public class FolderListViewModel : IFolderListViewModel
    {
        public IList<Folder> FolderList { get; set; }

        public FolderListViewModel()
        {
            Initialize();
        }

        private void Initialize()
        {
            FolderList =
                new Directory().GetFolders();
        }
    }
}