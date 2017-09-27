using System;

namespace SeliseFileExplorer.ViewModel.Interface
{
    public interface IFooterViewModel
    {
        string Name { get; set; }

        DateTime? ModifiedOn { get; set; }

        string Size { get; set; }

        bool IsSelected { get; }
    }
}