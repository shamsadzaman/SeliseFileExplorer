using System;
using GalaSoft.MvvmLight;

namespace SeliseFileExplorer.ViewModel
{
    public class FolderViewModel : ViewModelBase
    {
        private bool _isSelected;
        private string _name;
        private DateTime _modifiedOn;
        private string _size;
        private string _type;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                RaisePropertyChanged();
            }
        }

        public DateTime ModifiedOn
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

        public string Type
        {
            get { return _type; }
            set
            {
                _type = value; 
                RaisePropertyChanged();
            }
        }

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