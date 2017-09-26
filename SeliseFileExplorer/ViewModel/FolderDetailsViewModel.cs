using System.Collections.Generic;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using SeliseFileExplorer.Constants;
using SeliseFileExplorer.Model;

namespace SeliseFileExplorer.ViewModel
{
    public class FolderDetailsViewModel : ViewModelBase
    {
        private bool _isListView;
        private ObservableCollection<FolderViewModel> _viewList;
        private FolderViewType _folderViewType;
        private FolderViewModel _selectedFolderViewModel;
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
            MessengerInstance.Register<FolderViewType>(this, MessageToken.ChangeView, x => ChangeView(x));
            MessengerInstance.Register<DeleteFiles>(this, MessageToken.Delete, x => DeleteSelected());
        }

        private void ChangeView(FolderViewType folderViewType)
        {
            FolderViewType = folderViewType;
        }

        private void SetValue(DirectoryInfo o)
        {
            Folders = o.Folders;
            Files = o.Files;

            Initialize();
        }

        public void Initialize()
        {
            ViewList = new ObservableCollection<FolderViewModel>();

            Folders.ForEach(x => ViewList.Add(new FolderViewModel
            {
                Folder = x,
                Name = x.Name,
                Size = x.Size,
                ModifiedOn = x.ModifiedOn,
                Type = x.Type,
                NodeType = NodeType.Folder
            }));

            Files.ForEach(x => ViewList.Add(new FolderViewModel
            {
                File = x,
                Name = x.Name,
                Size = x.Size,
                ModifiedOn = x.ModifiedOn,
                Type = x.Type,
                NodeType = NodeType.File
            }));
        }

        public FolderViewModel SelectedFolderViewModel
        {
            get { return _selectedFolderViewModel; }
            set
            {
                _selectedFolderViewModel = value;
                RaisePropertyChanged();
            }
        }

        public void DeleteSelected()
        {
            if (SelectedFolderViewModel == null)
            {
                return;
            }

            // TODO: DI directory, remove strong coupling
            var directory = new Directory();

            if (SelectedFolderViewModel.NodeType == NodeType.Folder)
            {
                directory.DeleteFolder(SelectedFolderViewModel.Folder);
            }
            else
            {
                directory.DeleteFile(SelectedFolderViewModel.File);
            }

            ViewList.Remove(SelectedFolderViewModel);
            MessengerInstance.Send(new DeleteFiles(), MessageToken.RefreshTree);
        }
    }
}