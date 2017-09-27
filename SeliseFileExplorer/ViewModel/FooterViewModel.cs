using System;
using System.Windows;
using GalaSoft.MvvmLight;
using SeliseFileExplorer.Constants;
using SeliseFileExplorer.ViewModel.Interface;

namespace SeliseFileExplorer.ViewModel
{
    public class FooterViewModel : ViewModelBase, IFooterViewModel
    {
        private string _name;
        private DateTime? _modifiedOn;
        private string _size;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                RaisePropertyChanged();
            }
        }

        public DateTime? ModifiedOn
        {
            get { return _modifiedOn; }
            set
            {
                _modifiedOn = value;
                RaisePropertyChanged();
            }
        }

        public string Size
        {
            get { return _size; }
            set
            {
                _size = value;
                RaisePropertyChanged();
            }
        }

        public bool IsSelected
        {
            get { return Name != null; }
        }

        public FooterViewModel()
        {
            MessengerInstance.Register<FolderViewModel>(this, MessageToken.UpdateFooter, x => UpdateFooter(x));
        }

        private void UpdateFooter(FolderViewModel folderViewModel)
        {
            Name = folderViewModel.Name;
            ModifiedOn = folderViewModel.ModifiedOn;
            Size = folderViewModel.Size;
        }
    }
}