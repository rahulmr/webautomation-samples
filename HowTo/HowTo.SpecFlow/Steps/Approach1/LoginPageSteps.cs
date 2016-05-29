using HowTo.SpecFlow.Pages.Approach1_2;
using TechTalk.SpecFlow;
using WebAutomation.SpecFlow;

namespace HowTo.SpecFlow.Steps.Approach1
{
    [Binding]
    class LoginPageSteps : SpecFlowTestBase
    {
        public LoginPage LoginPage
        {
            get { return this.GetContainer<LoginPage>(); }
        }

        [When(@"I fill login form with ""(.*)"" and ""(.*)""")]
        public void WhenIFillLoginFormWithAnd(string username, string password)
        {
            this.LoginPage.UserTextbox.Perform.Fill(username);
            this.LoginPage.PasswordTextbox.Perform.Fill(password);
        }

        [When(@"I click on Login button")]
        public void WhenIClickOnLoginButton()
        {
            this.LoginPage.LoginButton.Perform.Click();
        }

        [Then(@"login message ""(.*)"" appears")]
        public void ThenLoginMessageAppears(string message)
        {
            this.LoginPage.Message.Assert.Has.Text(message);
        }
    }
}
