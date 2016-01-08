using OpenQA.Selenium.Firefox;
using System;
using WebAutomation.SpecflowGenericSteps;
using System.Configuration;

namespace WebAutomationSample.Tests.Common
{
    public class SpecFlowTest : SpecFlowTestBase
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

        public void NavigateToHomePage()
        {
            this.WebDriver.Navigate().GoToUrl(this.PageUrl);
        }

        public void OpenBrowser()
        {
            switch (this.BrowserType)
            {
                case "firefox":
                    this.WebDriver = new FirefoxDriver();
                    break;

                default:
                    throw new ArgumentException("Browser type not supported");
            }
            
            this.WebDriver.Manage().Window.Maximize();
        }
    }
}
