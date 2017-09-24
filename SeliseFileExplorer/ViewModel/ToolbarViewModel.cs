using System.Collections.Generic;
using System.Windows;
using SeliseFileExplorer.Command;
using SeliseFileExplorer.ViewModel.Interface;

namespace SeliseFileExplorer.ViewModel
{
    public class ToolbarViewModel : IToolBarViewModel
    {
        public List<ToolbarCommand> ToolbarCommandList { get; set; }

        public ToolbarViewModel()
        {
            Initialize();
        }

        public void Initialize()
        {
            ToolbarCommandList = new List<ToolbarCommand>
            {
                new ToolbarCommand
                {
                    Command = new DelegateCommand(Execute, CanExecute),
                    CommandName = "Delete"
                },
                new ToolbarCommand
                {
                    Command = new DelegateCommand(Execute, CanExecute),
                    CommandName = "Grid View"
                }
            };
        }

        private void Execute()
        {
            // talk to shell to call the appropriate viewmodel
            MessageBox.Show("Command executed");
        }

        private bool CanExecute()
        {
            // get data from shell
            return true;
        }
    }
}