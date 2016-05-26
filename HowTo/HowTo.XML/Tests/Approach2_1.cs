using NUnit.Framework;
using HowTo.XML.Pages.Approach2_1;
using WebAutomation.Core.WebObjects.WebComponents.Value;

namespace HowTo.XML.Tests
{
    [TestFixture]
    [Author("Marek Kudlinski")]
    [Category("Approach2_1")]
    [Property("type", "ui")]
    public class Approach2_1 : CustomTestBase
    {
        [Test]
        [Retry(2)]
        public void Approach2_1_NewsPage()
        {
            var expectedTableContent = new string[][]
            {
                new string[] {"ID 1", "First article", "Article 1 content"},
                new string[] {"ID 2", "Second article", "Article 2 content"}
            };

            this.GetContainer<MyWebsite>().MenuNewsButton.Perform.Click();

            var newsPage = this.GetContainer<NewsPage>();
            for (int i = 0; i < expectedTableContent.Length; i++)
            {
                var rowValues = expectedTableContent[i];
                string rowNumber = (i + 1).ToString();

                newsPage.TableRowId.With(rowNumber).Assert.Has.Text(rowValues[0]);
                newsPage.TableRowTitle.With(rowNumber).Assert.Has.Text(rowValues[1]);
                newsPage.TableRowContent.With(rowNumber).Assert.Has.Text(rowValues[2], StringType.Contains);
            }
        }

        [TestCase("Admin", "pass", "Your are logged!")]
        [TestCase("Admin", "wrong_pass", "Incorrect password!")]
        public void Approach2_1_LoginPage(string user, string password, string expectedMessage)
        {
            this.GetContainer<MyWebsite>().MenuLoginButton.Perform.Click();

            var loginPage = this.GetContainer<LoginPage>();
            loginPage.UserTextbox.Perform.Fill(user);
            loginPage.PasswordTextbox.Perform.Fill(password);
            loginPage.LoginButton.Perform.Click();

            var message = loginPage.Message;
            message.Assert.Is.Displayed();
            message.Assert.Has.Text(expectedMessage);
        }
    }
}
