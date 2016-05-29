using OpenQA.Selenium.Firefox;
using System.IO;
using TechTalk.SpecFlow;
using WebAutomation.Core;
using WebAutomation.SpecFlow;

namespace HowTo.SpecFlow.Steps
{
    [Binding]
    public class Common : SpecFlowTestBase
    {
        [AfterScenario]
        public void AfterScenario()
        {
            this.QuitBrowser();
        }

        [Given(@"I am on ""(.*)"" page")]
        public void GivenIAmOnPage(string pageName)
        {
            this.WebDriver = new FirefoxDriver();
            this.WebDriver.Navigate().GoToUrl(this.GetUrl(pageName));
        }

        protected string GetUrl(string pageName)
        {
            return Path.Combine(TestBase.AssemblyDirectory, "Resources", $"{pageName}.html");
        }
    }
}
