﻿using System.Threading;
using TechTalk.SpecFlow;
using WebAutomation.Core.WebObjects.WebComponents.Actions;
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
        [When(@"User navigates to '(.+)' page")]
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

        [When(@"User clicks on submit button")]
        public void WhenUserClicksOnSubmitButton()
        {
            this.Page.SubmitButton.Perform.Click();
        }

        [When(@"User clicks on '(.*)' button")]
        public void WhenUserClicksOnButton(string buttonName)
        {
            this.Page.ButtonByText.With(buttonName).Perform.Click();

            // After clicking on the button, the page is being scrolled to other place.
            // In that time, we are not able to operate on other elements (selenium exception will occur).
            // To avoid that problem, we have to determine when the scrolling ends.

            // Temporary solution (should be replaced in the future!)
            Thread.Sleep(1000);
        }
    }
}