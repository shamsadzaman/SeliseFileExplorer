﻿using System;
using System.Windows;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using SeliseFileExplorer.Command;
using SeliseFileExplorer.Constants;
using SeliseFileExplorer.Model;

namespace SeliseFileExplorer.ViewModel
{
    public class FolderViewModel : ViewModelBase
    {
        private bool _isSelected;
        private string _name;
        private DateTime _modifiedOn;
        private string _size;
        private string _type;
        private Folder _folder;
        private File _file;

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

        public ICommand OpenFileCommand => new DelegateCommand(OpenFile, CanOpenFile);

        public NodeType NodeType { get; set; }

        public Folder Folder
        {
            get { return _folder; }
            set
            {
                _folder = value;
                RaisePropertyChanged();
            }
        }

        public File File
        {
            get { return _file; }
            set
            {
                _file = value;
                RaisePropertyChanged();
            }
        }

        private bool CanOpenFile()
        {
            return NodeType == NodeType.File;
        }

        private void OpenFile()
        {
            MessageBox.Show(Name);
        }
    }
}