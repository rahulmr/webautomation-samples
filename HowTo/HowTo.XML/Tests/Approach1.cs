using NUnit.Framework;
using HowTo.XML.Pages.Approach1;
using WebAutomation.Core.WebObjects.WebComponents.Value;

namespace HowTo.XML.Tests
{
    [TestFixture]
    [Author("Marek Kudlinski")]
    [Category("Approach1")]
    [Property("type", "ui")]
    public class Approach1 : CustomTestBase
    {
        [Test]
        [Retry(2)]
        public void Approach1_NewsPage()
        {
            this.GetContainer<MyWebsite>().MenuNewsButton.Perform.Click();

            var newsPage = this.GetContainer<NewsPage>();
            newsPage.TableRow1Id.Assert.Has.Text("ID 1");
            newsPage.TableRow1Title.Assert.Has.Text("First article");
            newsPage.TableRow1Content.Assert.Has.Text("Article 1 content", StringType.Contains);

            newsPage.TableRow2Id.Assert.Has.Text("ID 2");
            newsPage.TableRow2Title.Assert.Has.Text("Second article");
            newsPage.TableRow2Content.Assert.Has.Text("Article 2 content", StringType.Contains);
        }

        [Test]
        [Retry(2)]
        public void Approach1_LoginPage_Success()
        {
            this.GetContainer<MyWebsite>().MenuLoginButton.Perform.Click();

            var loginPage = this.GetContainer<LoginPage>();
            loginPage.UserTextbox.Perform.Fill("Admin");
            loginPage.PasswordTextbox.Perform.Fill("pass");
            loginPage.LoginButton.Perform.Click();

            loginPage.SuccessMessage.Assert.Is.Displayed();
        }

        [Test]
        [Retry(2)]
        public void Approach1_LoginPage_Error()
        {
            this.GetContainer<MyWebsite>().MenuLoginButton.Perform.Click();

            var loginPage = this.GetContainer<LoginPage>();
            loginPage.UserTextbox.Perform.Fill("Admin");
            loginPage.PasswordTextbox.Perform.Fill("wrong_pass");
            loginPage.LoginButton.Perform.Click();

            loginPage.ErrorMessage.Assert.Is.Displayed();
        }
    }
}
