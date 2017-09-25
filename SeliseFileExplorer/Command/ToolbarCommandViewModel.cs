using System.Windows.Input;
using GalaSoft.MvvmLight;
using SeliseFileExplorer.Constants;

namespace SeliseFileExplorer.Command
{
    public class ToolbarCommandViewModel : ViewModelBase
    {
        private ToolbarCommandType _commandType;

        public ICommand Command { get; set; }

        public ToolbarCommandType CommandType
        {
            get { return _commandType; }
            set
            {
                _commandType = value;
                RaisePropertyChanged();
            }
        }
    }
}