using TechTalk.SpecFlow;
using QualityExcites.Tests.Common;

namespace QualityExcites.Tests.Steps
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
