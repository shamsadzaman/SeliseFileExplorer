using System.Windows.Input;
using System.Windows.Media;
using GalaSoft.MvvmLight;
using SeliseFileExplorer.Constants;

namespace SeliseFileExplorer.Command
{
    public class ToolbarCommandViewModel : ViewModelBase
    {
        private string _commandDisplayName;
        private ImageSource _commandIconLocation;
        private ToolbarCommandType _commandType;
        public ICommand Command { get; set; }

        public string CommandDisplayName
        {
            get { return _commandDisplayName; }
            set
            {
                _commandDisplayName = value;
                RaisePropertyChanged();
            }
        }

        public ImageSource CommandIconLocation
        {
            get { return _commandIconLocation; }
            set
            {
                _commandIconLocation = value;
                RaisePropertyChanged();
            }
        }

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