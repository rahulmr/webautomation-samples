using NUnit.Framework;
using HowTo.XML.Pages.Approach3;

namespace HowTo.XML.Tests
{
    [TestFixture]
    public class Approach3 : CustomTestBase
    {
        /// <summary>
        /// No changes here
        /// (only XML updated)
        /// </summary>
        [Test]
        public void Approach3_NewsPage()
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
        /// (only XML updated)
        /// </summary>
        [TestCase("Admin", "pass", "Your are logged!")]
        [TestCase("Admin", "wrong_pass", "Incorrect password!")]
        public void Approach3_LoginPage(string user, string password, string expectedMessage)
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
