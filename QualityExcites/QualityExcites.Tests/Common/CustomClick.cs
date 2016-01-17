using System.Threading;
using OpenQA.Selenium;
using WebAutomation.Core.WebObjects.WebComponents.Actions;

namespace QualityExcites.Tests.Common
{
    public class CustomClick : IClickAction
    {
        protected IClickAction DefaultClick { get; set; }
        protected IWebDriver WebDriver { get; set; }

        public CustomClick()
        {
            this.DefaultClick = new ClickAction();
        }

        public bool Click(ClickType clickType = ClickType.Mouse)
        {
            // When clicking on the button, the page is being scrolled to other place.
            // In that time, we are not able to operate on other elements (selenium exception will occur).
            // To avoid that problem, we have to determine when the scrolling ends.
            this.WaitForScrolling();
            return this.DefaultClick.Click(clickType);
        }

        public void SetWebDriver(OpenQA.Selenium.IWebDriver webDriver)
        {
            this.WebDriver = webDriver;
            this.DefaultClick.SetWebDriver(webDriver);
        }

        public void SetWebElement(OpenQA.Selenium.IWebElement webElement)
        {
            this.DefaultClick.SetWebElement(webElement);
        }

        private void WaitForScrolling()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)this.WebDriver;

            int attempts = 20;
            while (attempts-- > 0)
            {
                int scrollPosition = int.Parse(js.ExecuteScript("return window.pageYOffset;").ToString());
                Thread.Sleep(100);
                int scrollNewPosition = int.Parse(js.ExecuteScript("return window.pageYOffset;").ToString());

                if (scrollPosition == scrollNewPosition)
                {
                    return;
                }
            }
        }
    }
}
