using TechTalk.SpecFlow;
using WebAutomationSample.Tests.Common;
using WebAutomationSample.Tests.Pages;

namespace WebAutomationSample.Tests.Steps
{
    [Binding]
    public class NavigationSteps : SpecFlowTest
    {
        public QualityExcitesPage Page
        {
            get
            {
                return this.GetContainer<QualityExcitesPage>();
            }
        }

        [Given(@"User navigates to '(.+)' page")]
        public void GivenIDoSomething(string pageName)
        {
            var menuLink = this.Page.MenuLink.With(pageName);
            menuLink.Assert.Is.Displayed();
            menuLink.Perform.Click();
        }

        [Then(@"'(.*)' page is displayed")]
        public void ThenPageIsDisplayed(string pageName)
        {
            var header = this.Page.Header;
            header.Assert.Is.Displayed();
            header.Assert.Has.Text(pageName.ToUpper());
        }
    }
}