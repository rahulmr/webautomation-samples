using NUnit.Framework;
using HowTo.XML.Pages.Approach0;
using WebAutomation.Core.WebObjects.WebComponents.Value;

namespace HowTo.XML.Tests
{
    [TestFixture]
    public class Approach0 : CustomTestBase
    {
        [Test]
        public void Approach0_NewsPage()
        {
            var newsPage = this.GetContainer<NewsPage>();
            newsPage.MenuNewsButton.Perform.Click();

            newsPage.TableRow1Id.Assert.Has.Text("ID 1");
            newsPage.TableRow1Title.Assert.Has.Text("First article");
            newsPage.TableRow1Content.Assert.Has.Text("Article 1 content", StringType.Contains);

            newsPage.TableRow2Id.Assert.Has.Text("ID 2");
            newsPage.TableRow2Title.Assert.Has.Text("Second article");
            newsPage.TableRow2Content.Assert.Has.Text("Article 2 content", StringType.Contains);
        }

        [Test]
        public void Approach0_LoginPage_Success()
        {
            var loginPage = this.GetContainer<LoginPage>();
            loginPage.MenuLoginButton.Perform.Click();

            loginPage.UserTextbox.Perform.Fill("Admin");
            loginPage.PasswordTextbox.Perform.Fill("pass");
            loginPage.LoginButton.Perform.Click();

            loginPage.SuccessMessage.Assert.Is.Displayed();
        }

        [Test]
        public void Approach0_LoginPage_Error()
        {
            var loginPage = this.GetContainer<LoginPage>();
            loginPage.MenuLoginButton.Perform.Click();

            loginPage.UserTextbox.Perform.Fill("Admin");
            loginPage.PasswordTextbox.Perform.Fill("wrong_pass");
            loginPage.LoginButton.Perform.Click();

            loginPage.ErrorMessage.Assert.Is.Displayed();
        }
    }
}
