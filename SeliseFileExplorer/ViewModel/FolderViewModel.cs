using System;
using GalaSoft.MvvmLight;

namespace SeliseFileExplorer.ViewModel
{
    public class FolderViewModel : ViewModelBase
    {
        private bool _isSelected;
        public string Name { get; set; }

        public DateTime ModifiedOn { get; set; }

        public string Size { get; set; }

        public string Type { get; set; }

        public bool IsSelected
        {
            get { return _isSelected; }
            set
            {
                _isSelected = value; 
                RaisePropertyChanged();
            }
        }
    }
}