using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using GalaSoft.MvvmLight;
using SeliseFileExplorer.Config;
using SeliseFileExplorer.Model;
using SeliseFileExplorer.ViewModel.Interface;

namespace SeliseFileExplorer.ViewModel
{
    public class HeaderViewModel : ViewModelBase, IHeaderViewModel
    {
        private readonly IAppConfig _config;
        private Theme _selectedTheme;
        public string LogoImageLocation { get; set; }
        public string HeaderTitle { get; set; }
        public List<Theme> ThemeList { get; set; }

        public Theme SelectedTheme
        {
            get { return _selectedTheme; }
            set
            {
                _selectedTheme = value;
                OnThemeChange();
                RaisePropertyChanged();
            }
        }

        private void OnThemeChange()
        {
            //throw new NotImplementedException();
        }

        public ImageSource LogoSource { get; set; }

        public HeaderViewModel(IAppConfig config)
        {
            _config = config;
            Initialize();
        }

        public void Initialize()
        {
            // "pack://application:,,,/AssemblyName;component/Resources/logo.png"
            var logoLocation = "Image/logo.jpg";
            LogoSource = new BitmapImage(new Uri(_config.ResourceLocation + logoLocation));

            LogoImageLocation = "";
            HeaderTitle = "File Explorer";
            ThemeList = new List<Theme>
            {
                new Theme
                {
                    ThemeId = ThemeId.Theme1,
                    ThemeName = "Theme 1"
                },
                new Theme
                {
                    ThemeId = ThemeId.Theme2,
                    ThemeName = "Theme 2"
                }
            };

            SelectedTheme = ThemeList.First();
        }
    }
}