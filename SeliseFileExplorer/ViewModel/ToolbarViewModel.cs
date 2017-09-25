using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media.Imaging;
using GalaSoft.MvvmLight;
using SeliseFileExplorer.Command;
using SeliseFileExplorer.Config;
using SeliseFileExplorer.Constants;
using SeliseFileExplorer.ViewModel.Interface;

namespace SeliseFileExplorer.ViewModel
{
    public class ToolbarViewModel : ViewModelBase, IToolBarViewModel
    {
        private IAppConfig _config;
        public List<ToolbarCommandViewModel> ToolbarCommandList { get; set; }

        public FolderViewType CurrentFolderViewType { get; set; }

        public ToolbarViewModel(IAppConfig config)
        {
            _config = config;
            Initialize();
        }

        public void Initialize()
        {
            ChangeViewCommandViewModel = new ToolbarCommandViewModel
            {
                Command = new DelegateCommand(ChangeView, CanChangeView),
                CommandDisplayName = "Grid View"
            };

            ToolbarCommandList = new List<ToolbarCommandViewModel>
            {
                new ToolbarCommandViewModel
                {
                    Command = new DelegateCommand(Execute, CanExecute),
                    CommandDisplayName = "Delete"
                },
                ChangeViewCommandViewModel
            };
        }

        public ToolbarCommandViewModel ChangeViewCommandViewModel { get; set; }

        private bool CanChangeView()
        {
            return true;
        }

        private void ChangeView()
        {
            if (CurrentFolderViewType == FolderViewType.List)
            {
                CurrentFolderViewType = FolderViewType.Grid;
                ChangeViewCommandViewModel.CommandDisplayName = "List View";
                var logoLocation = "Image/ListView.png";
                //new BitmapImage(new Uri(@"pack://application:,,,/SeliseFileExplorer;component/" + logoLocation));
                ChangeViewCommandViewModel.CommandIconLocation = new BitmapImage(
                    new Uri(_config.ResourceLocation + logoLocation));
            }
            else
            {
                CurrentFolderViewType = FolderViewType.List;
                ChangeViewCommandViewModel.CommandDisplayName = "Grid View";
                var logoLocation = "Image/TileView.png";
                //new BitmapImage(new Uri(@"pack://application:,,,/SeliseFileExplorer;component/" + logoLocation));
                ChangeViewCommandViewModel.CommandIconLocation = new BitmapImage(
                    new Uri(_config.ResourceLocation + logoLocation));
            }

            MessengerInstance.Send(CurrentFolderViewType, MessageToken.ChangeView);
        }

        private void Execute()
        {
            // talk to shell to call the appropriate viewmodel
            MessageBox.Show("Delete - Not yet implemented");
        }

        private bool CanExecute()
        {
            // get data from shell
            return true;
        }
    }
}