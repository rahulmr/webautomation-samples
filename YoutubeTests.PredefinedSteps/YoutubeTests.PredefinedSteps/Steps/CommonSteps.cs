using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;
using WebAutomation.SpecFlow;
using WebAutomation.SpecflowGenericSteps;

namespace YoutubeTests.PredefinedSteps.Steps
{
    [Binding]
    public class CommonSteps : SpecFlowTestBase
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            this.WebDriver = new ChromeDriver();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            this.QuitBrowser();
        }
    }
}
