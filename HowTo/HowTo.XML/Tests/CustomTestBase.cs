using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using System.IO;
using WebAutomation.Core;

namespace HowTo.XML.Tests
{
    public class CustomTestBase : TestBase
    {
        protected string HomePagePath
        {
            get
            {
                return Path.Combine(TestBase.AssemblyDirectory, "Resources", "Home.html");
            }
        }

        [SetUp]
        public void SetUp()
        {
            this.Logger.Info("Start test: {0}", TestContext.CurrentContext.Test.Name);
            this.WebDriver = new FirefoxDriver();
            this.WebDriver.Navigate().GoToUrl(this.HomePagePath);
        }

        [TearDown]
        public void TearDown()
        {
            this.QuitBrowser();
            this.Logger.Info("Test result: {0}", TestContext.CurrentContext.Result.Status);
            this.Logger.Info("================================\n");

        }
    }
}