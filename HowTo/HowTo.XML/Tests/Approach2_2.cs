using NUnit.Framework;
using HowTo.XML.Pages.Approach2_2;

namespace HowTo.XML.Tests
{
    [TestFixture]
    public class Approach2_2 : CustomTestBase
    {
        [Test]
        public void Approach2_2_NewsPage()
        {
            var expectedTableContent = new string[][]
            {
                new string[] {"1", "ID 1", "First article", "Article 1 content"},
                new string[] {"2", "ID 2", "Second article", "Article 2 content"}
            };

            this.GetContainer<MyWebsite>().MenuNewsButton.Perform.Click();

            var newsPage = this.GetContainer<NewsPage>();
            foreach (var row in expectedTableContent)
            {
                newsPage.TableRowByValues.With(row).Assert.Is.Displayed();
            }
        }

        /// <summary>
        /// No changes here
        /// </summary>
        [TestCase("Admin", "pass", "Your are logged!")]
        [TestCase("Admin", "wrong_pass", "Incorrect password!")]
        public void Approach2_2_LoginPage(string user, string password, string expectedMessage)
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
