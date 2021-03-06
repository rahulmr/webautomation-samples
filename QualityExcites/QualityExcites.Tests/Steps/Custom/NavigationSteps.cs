﻿using System.Threading;
using TechTalk.SpecFlow;
using WebAutomation.Core.WebObjects.WebComponents.Actions;
using QualityExcites.Tests.Common;
using QualityExcites.Tests.Pages;

namespace QualityExcites.Tests.Steps
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
        }
    }
}