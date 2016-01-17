using System;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using WebAutomation.Core;
using YoutubeTests.Pages;

namespace YoutubeTests
{
    [TestFixture]
    public class Tests : TestBase
    {
        [TestCase("Hans Zimmer greatest hits", "The greatest hits from Hans Zimmer")]
        public void OpenVideo(string input, string expectedLink)
        {
            this.WebDriver = new FirefoxDriver();
            this.WebDriver.Navigate().GoToUrl("http://www.youtube.com");

            var youtubePage = this.GetContainer<YoutubePage>();
            youtubePage.SearchInput.Perform.Fill(input);
            youtubePage.OkButton.Perform.Click();

            var searchResultsPage = this.GetContainer<YoutubeSearchResultPage>();
            searchResultsPage.Link.With(expectedLink).Perform.Click();

            var playerPage = this.GetContainer<YoutubePlayerPage>();
            playerPage.Player.Assert.Is.Displayed();

            this.QuitBrowser();
        }
    }
}