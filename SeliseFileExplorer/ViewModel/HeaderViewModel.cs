using System;
using System.Collections.Generic;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using SeliseFileExplorer.ViewModel.Interface;

namespace SeliseFileExplorer.ViewModel
{
    public class HeaderViewModel : IHeaderViewModel
    {
        public string LogoImageLocation { get; set; }
        public string HeaderTitle { get; set; }
        public List<string> ThemeList { get; set; }

        public ImageSource LogoSource { get; set; }

        public HeaderViewModel()
        {
            Initialize();
        }

        public void Initialize()
        {
            // "pack://application:,,,/AssemblyName;component/Resources/logo.png"
            var logoLocation = "Image/logo.jpg";
            LogoSource = new BitmapImage(new Uri(@"pack://application:,,,/SeliseFileExplorer;component/" + logoLocation));

            LogoImageLocation = "";
            HeaderTitle = "File Explorer";
            ThemeList = new List<string>
            {
                "Theme 1",
                "Theme 2"
            };
        }
    }
}