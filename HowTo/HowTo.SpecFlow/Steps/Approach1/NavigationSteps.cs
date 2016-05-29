using HowTo.SpecFlow.Pages.Approach1_2;
using TechTalk.SpecFlow;
using WebAutomation.SpecFlow;

namespace HowTo.SpecFlow.Steps.Approach1
{
    [Binding]
    class NavigationSteps : SpecFlowTestBase
    {
        [When(@"I click on News button in top menu")]
        public void WhenIClickOnButtonInTopMenu()
        {
            this.GetContainer<MyWebsite>().MenuNewsButton.Perform.Click();
        }

        [When(@"I click on Login button in top menu")]
        public void WhenIClickOnLoginButtonInTopMenu()
        {
            this.GetContainer<MyWebsite>().MenuLoginButton.Perform.Click();
        }
    }
}
