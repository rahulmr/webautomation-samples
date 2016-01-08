using TechTalk.SpecFlow;
using WebAutomationSample.Tests.Common;

namespace WebAutomationSample.Tests.Steps
{
    [Binding]
    public class ScenarioSteps : SpecFlowTest
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
