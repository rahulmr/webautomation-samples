using TechTalk.SpecFlow;
using WebAutomationSample.Tests.Common;
using WebAutomationSample.Tests.Pages;

namespace WebAutomationSample.Tests.Steps
{
    [Binding]
    public class CallForProposalsSteps : SpecFlowTest
    {
        [Then(@"User is successfully registered")]
        public void ThenUserIsSuccessfullyRegistered()
        {
            this.GetContainer<CallForProposalsPage>().Header.Assert.WillHave.Text("THANK YOU");
        }
    }
}
