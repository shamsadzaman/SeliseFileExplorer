using System.Configuration;

namespace SeliseFileExplorer.Config
{
    public class AppConfig : IAppConfig
    {
        string IAppConfig.ResourceLocation => ConfigurationManager.AppSettings["ResourceLocation"];
    }
}