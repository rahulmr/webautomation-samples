using System.Configuration;

namespace QualityExcites.Tests.Common
{
    public class Settings
    {
        public string PageUrl
        {
            get
            {
                return ConfigurationManager.AppSettings["PageUrl"];
            }
        }

        public string BrowserType
        {
            get
            {
                return ConfigurationManager.AppSettings["BrowserType"];
            }
        }
    }
}
