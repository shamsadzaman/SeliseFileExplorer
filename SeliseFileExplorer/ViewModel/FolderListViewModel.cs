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

            FolderList.ForEach(x => FolderTreeViewModelList.Add(
                new FolderTreeViewModel
                {
                    Name = x.Name,
                    Files = x.FileList,
                    Folders = x.FolderList
                }
            ));
        }
    }

    public class FolderTreeViewModel : ViewModelBase
    {
        private bool _isSelected;
        public string Name { get; set; }

        public List<Folder> Folders { get; set; }

        public List<Model.File> Files { get; set; }

        public bool IsSelected
        {
            get { return _isSelected; }
            set
            {
                _isSelected = value;
                ShowFolderDetails();
                RaisePropertyChanged();
            }
        }

        private void ShowFolderDetails()
        {
            MessageBox.Show("Test");
            var info = new DirectoryInfo
            {
                Files = Files,
                Folders = Folders
            };

            MessengerInstance.Send(info, MessageToken.FolderDetailsViewModel);
        }
    }
}