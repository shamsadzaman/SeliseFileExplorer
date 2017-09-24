using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows;
using GalaSoft.MvvmLight;
using SeliseFileExplorer.Constants;
using SeliseFileExplorer.Model;
using SeliseFileExplorer.ViewModel.Interface;
using Directory = SeliseFileExplorer.Model.Directory;
using File = SeliseFileExplorer.Model.File;

namespace SeliseFileExplorer.ViewModel
{
    public class FolderListViewModel : IFolderListViewModel
    {
        public List<Folder> FolderList { get; set; }

        public ObservableCollection<FolderTreeViewModel> FolderTreeViewModelList { get; set; }

        public FolderListViewModel()
        {
            Initialize();
        }

        private void Initialize()
        {
            FolderList =
                new Directory().GetFolders();

            FolderTreeViewModelList = new ObservableCollection<FolderTreeViewModel>();

            FolderList.ForEach(x => FolderTreeViewModelList.Add(new FolderTreeViewModel(x)));


            //FolderList.ForEach(x => FolderTreeViewModelList.Add(
            //    new FolderTreeViewModel
            //    {
            //        Name = x.Name,
            //        Files = x.FileList,
            //        Folders = x.FolderList
            //    }
            //));
        }
    }

    public class FolderTreeViewModel : ViewModelBase
    {
        private bool _isSelected;
        private Folder _folder;
        private FolderTreeViewModel _parentFolder;
        private List<File> _files;

        public FolderTreeViewModel(Folder folder) : this(folder, null)
        {
            
        }

        private FolderTreeViewModel(Folder folder, FolderTreeViewModel parent)
        {
            _folder = folder;
            _parentFolder = parent;

            Folders = new ObservableCollection<FolderTreeViewModel>(_folder.FolderList.Select(x => new FolderTreeViewModel(x, this)));
            Files = folder.FileList;
        }

        public string Name => _folder.Name;

        public ObservableCollection<FolderTreeViewModel> Folders { get; }

        public List<Model.File> Files { get; }

        public bool IsSelected
        {
            get { return _isSelected; }
            set
            {
                _isSelected = value;
                if (_isSelected)
                {
                    ShowFolderDetails();
                }
                RaisePropertyChanged();
            }
        }

        private void ShowFolderDetails()
        {
            MessageBox.Show("File Count: " + Files.Count + "\nFolder Count: " + Folders.Count + "\nIsSelected: " + _isSelected 
                + "\nFolder Name: " + Name);
            //var info = new DirectoryInfo
            //{
            //    Files = Files,
            //    Folders = Folders
            //};

            //MessengerInstance.Send(info, MessageToken.FolderDetailsViewModel);
        }
    }
}