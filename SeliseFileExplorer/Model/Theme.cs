namespace SeliseFileExplorer.Model
{
    public class Theme
    {
        public ThemeId ThemeId { get; set; }

        public string ThemeName { get; set; }
    }

    public enum ThemeId
    {
        Theme1,
        Theme2
    }
}