using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using SeliseFileExplorer.Constants;
using SeliseFileExplorer.Model;

namespace SeliseFileExplorer.ViewModel
{
    public class FolderDetailsViewModel : ViewModelBase
    {
        private bool _isListView;
        private ObservableCollection<FolderViewModel> _viewList;
        private FolderViewType _folderViewType;
        public List<Folder> Folders { get; set; }

        public List<File> Files { get; set; }

        public bool IsListView
        {
            get { return _isListView; }
            set
            {
                _isListView = value;
                RaisePropertyChanged();
            }
        }

        public ObservableCollection<FolderViewModel> ViewList
        {
            get { return _viewList; }
            set
            {
                _viewList = value;
                RaisePropertyChanged();
            }
        }

        public FolderViewType FolderViewType
        {
            get { return _folderViewType; }
            set
            {
                _folderViewType = value;
                RaisePropertyChanged();
            }
        }

        public FolderDetailsViewModel()
        {
            MessengerInstance.Register<DirectoryInfo>(this, MessageToken.FolderDetailsViewModel, x => SetValue(x));
        }

        private void SetValue(DirectoryInfo o)
        {
            //MessageBox.Show("Folders: " + o.Folders.Count + "\nFiles: " + o.Files.Count);
            Folders = o.Folders;
            Files = o.Files;

            Initialize();
        }

        public void Initialize()
        {
            ViewList = new ObservableCollection<FolderViewModel>();

            Folders.ForEach(x => ViewList.Add(new FolderViewModel
            {
                Name = x.Name,
                Size = x.Size,
                ModifiedOn = x.ModifiedOn,
                Type = x.Type,
                NodeType = NodeType.Folder
            }));

            Files.ForEach(x => ViewList.Add(new FolderViewModel
            {
                Name = x.Name,
                Size = x.Size,
                ModifiedOn = x.ModifiedOn,
                Type = x.Type,
                NodeType = NodeType.File
            }));

            FolderViewType = FolderViewType.Grid;
        }

        public void Delete()
        {
            // delete selected files
        }
    }
}