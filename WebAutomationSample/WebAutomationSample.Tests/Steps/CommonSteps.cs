using TechTalk.SpecFlow;
using WebAutomationSample.Tests.Common;

namespace WebAutomationSample.Tests.Steps
{
    [Binding]
    public class CommonSteps : SpecFlowTest
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            this.OpenBrowser();
            this.NavigateToHomePage();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            this.QuitBrowser();
        }
    }
}
