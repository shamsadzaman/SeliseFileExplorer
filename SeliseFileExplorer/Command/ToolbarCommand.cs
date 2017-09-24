using System.Windows.Input;

namespace SeliseFileExplorer.Command
{
    public class ToolbarCommand
    {
        public ICommand Command { get; set; }

        public string CommandName { get; set; }

        public string CommandIconLocation { get; set; }
    }
}