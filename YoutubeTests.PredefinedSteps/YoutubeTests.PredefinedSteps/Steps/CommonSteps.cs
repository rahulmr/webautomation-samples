using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;
using WebAutomation.SpecflowGenericSteps;

namespace YoutubeTests.PredefinedSteps.Steps
{
    [Binding]
    public class CommonSteps : SpecFlowTestBase
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            this.WebDriver = new FirefoxDriver();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            this.QuitBrowser();
        }
    }
}
