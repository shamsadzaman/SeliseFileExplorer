using System.Windows.Input;
using System.Windows.Media;
using GalaSoft.MvvmLight;

namespace SeliseFileExplorer.Command
{
    public class ToolbarCommandViewModel : ViewModelBase
    {
        private string _commandDisplayName;
        private ImageSource _commandIconLocation;
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
    }
}