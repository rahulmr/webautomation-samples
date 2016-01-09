using OpenQA.Selenium.Firefox;
using System;
using WebAutomation.SpecflowGenericSteps;
using System.Configuration;

namespace WebAutomationSample.Tests.Common
{
    public class SpecFlowTest : SpecFlowTestBase
    {
        public Settings Settings { get; set; }

        public SpecFlowTest()
        {
            this.Settings = new Settings();
        }

        public void OpenBrowser()
        {
            switch (this.Settings.BrowserType)
            {
                case "firefox":
                    this.WebDriver = new FirefoxDriver();
                    break;

                default:
                    throw new ArgumentException("Browser type not supported");
            }
            
            this.WebDriver.Manage().Window.Maximize();
        }

        public void NavigateToHomePage()
        {
            this.WebDriver.Navigate().GoToUrl(this.Settings.PageUrl);
        }
    }
}
