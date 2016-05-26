using Microsoft.Practices.Unity;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using System.IO;
using WebAutomation.Core;
using WebAutomation.Core.Logger;

namespace HowTo.XML.Tests
{
    public class CustomTestBase : TestBase
    {
        public CustomTestBase()
        {
            DependencyContainer.Container.RegisterType<ILogger, NUnit3Logger>();
        }

        protected string HomePagePath
        {
            get
            {
                return Path.Combine(TestBase.AssemblyDirectory, "Resources", "Home.html");
            }
        }

        [OneTimeSetUp]
        public void BeforeAllTests()
        {
            this.WebDriver = new FirefoxDriver();
        }

        [OneTimeTearDown]
        public void AfterAllTests()
        {
            this.QuitBrowser();
        }

        [SetUp]
        public void BeforeTest()
        {
            this.Logger.Info("Start test: {0}", TestContext.CurrentContext.Test.Name);     
            this.WebDriver.Navigate().GoToUrl(this.HomePagePath);
        }

        [TearDown]
        public void AfterTest()
        {
            this.Logger.Info("Test result: {0}", TestContext.CurrentContext.Result.Outcome.Status);
            this.Logger.Info("================================\n");
        }
    }
}