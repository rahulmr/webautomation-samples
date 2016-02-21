using System;
using Microsoft.Practices.Unity;
using OpenQA.Selenium.Firefox;
using WebAutomation.Core;
using WebAutomation.Core.WebObjects.WebComponents.Actions;
using WebAutomation.SpecFlow;

namespace QualityExcites.Tests.Common
{
    public class SpecFlowTest : SpecFlowTestBase
    {
        public Settings Settings { get; set; }

        public SpecFlowTest()
        {
            this.Settings = new Settings();
            DependencyContainer.Container.RegisterType<IClickAction, CustomClick>();
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
