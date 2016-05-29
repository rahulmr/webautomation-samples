//-----------------------------------------------------------------------
// Copyright (c) 2015 Marek Kudliński (meros)
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.  IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//-----------------------------------------------------------------------
namespace WebAutomation.SpecflowGenericSteps
{
    using System.Collections.Generic;
    using System.Linq;
    using TechTalk.SpecFlow;
    using WebAutomation.Core.WebObjects.WebComponents.Actions;
    using WebAutomation.Core.WebObjects.WebComponents.Value;
    using WebAutomation.SpecFlow;

    /// <summary>
    /// SpecFlow generic steps.
    /// </summary>
    [Binding]
    public class SpecFlowGenericSteps : SpecFlowTestBase
    {
        #region Converters

        /// <summary>
        /// String type converter.
        /// </summary>
        private static readonly Dictionary<string, StringType> StringTypes = new Dictionary<string, StringType>
        {
            { "equal to", StringType.Equals },
            { "not equal to", StringType.NotEquals },
            { "which contains", StringType.Contains },
            { "which not contains", StringType.NotContains },
            { "which starts with", StringType.StartsWith },
            { "which ends with",  StringType.EndsWith }
        };

        /// <summary>
        /// Number type converter.
        /// </summary>
        private static readonly Dictionary<string, NumberType> NumericTypes = new Dictionary<string, NumberType>
        {
           { "equal to", NumberType.Equals },
           { "not equal to", NumberType.NotEquals },
           { "greater than", NumberType.GreaterThan },
           { "greater than or equal to", NumberType.GreaterThanOrEqualTo },
           { "less than", NumberType.LessThan },
           { "less than or equal to", NumberType.LessThanOrEqualTo }
        };

        /// <summary>
        /// Option type converter.
        /// </summary>
        private static readonly Dictionary<string, OptionType> OptionTypes = new Dictionary<string, OptionType>
        {
            { "selected", OptionType.Selected },
            { "not selected", OptionType.NotSelected },
            { "available", OptionType.Available },
            { "not available", OptionType.NotAvailable }
        };

        #endregion

        #region Given

        [Given(@"user navigates to '(.*)'")]
        public void GivenUserNavigatesTo(string url)
        {
            this.WebDriver.Navigate().GoToUrl(url);
        }

        [Given(@"user closes the web browser")]
        public void GivenUserClosesTheWebBrowser()
        {
            this.QuitBrowser();
        }

        #endregion

        #region When

        #region Check

        [When(@"user checks '(.+)-(.+)'")]
        public void ActionCheck(string webContainerName, string webComponentName)
        {
            this.GetWebComponent(webContainerName, webComponentName).Perform.Check();
        }

        [When(@"user checks '(.+)-(.+)'")]
        public void ActionCheck(string webContainerName, string webComponentName, Table parameters)
        {
            foreach (var row in parameters.Rows)
            {
                this.GetWebComponent(webContainerName, webComponentName).With(row.Values.ToArray()).Perform.Check();
            }
        }

        [When(@"user checks '(.+)-(.+)' if exists")]
        public void ActionCheckIfExists(string webContainerName, string webComponentName)
        {
            this.GetWebComponent(webContainerName, webComponentName).PerformIfExists.Check();
        }

        [When(@"user checks '(.+)-(.+)' if exists")]
        public void ActionCheckIfExists(string webContainerName, string webComponentName, Table parameters)
        {
            foreach (var row in parameters.Rows)
            {
                this.GetWebComponent(webContainerName, webComponentName).With(row.Values.ToArray()).PerformIfExists.Check();
            }
        }

        #endregion

        #region Uncheck

        [When(@"user unchecks '(.+)-(.+)'")]
        public void ActionUnCheck(string webContainerName, string webComponentName)
        {
            this.GetWebComponent(webContainerName, webComponentName).Perform.Uncheck();
        }

        [When(@"user unchecks '(.+)-(.+)'")]
        public void ActionUnCheck(string webContainerName, string webComponentName, Table parameters)
        {
            foreach (var row in parameters.Rows)
            {
                this.GetWebComponent(webContainerName, webComponentName).With(row.Values.ToArray()).Perform.Uncheck();
            }
        }

        [When(@"user unchecks '(.+)-(.+)' if exists")]
        public void ActionUnCheckIfExists(string webContainerName, string webComponentName)
        {
            this.GetWebComponent(webContainerName, webComponentName).PerformIfExists.Uncheck();
        }

        [When(@"user unchecks '(.+)-(.+)' if exists")]
        public void ActionUnCheckIfExists(string webContainerName, string webComponentName, Table parameters)
        {
            foreach (var row in parameters.Rows)
            {
                this.GetWebComponent(webContainerName, webComponentName).With(row.Values.ToArray()).PerformIfExists.Uncheck();
            }
        }

        #endregion

        #region Clear

        [When(@"user clears '(.+)-(.+)'")]
        public void ActionClear(string webContainerName, string webComponentName)
        {
            this.GetWebComponent(webContainerName, webComponentName).Perform.Clear();
        }

        [When(@"user clears '(.+)-(.+)'")]
        public void ActionClear(string webContainerName, string webComponentName, Table parameters)
        {
            foreach (var row in parameters.Rows)
            {
                this.GetWebComponent(webContainerName, webComponentName).With(row.Values.ToArray()).Perform.Clear();
            }
        }

        [When(@"user clears '(.+)-(.+)' if exists")]
        public void ActionClearIfExists(string webContainerName, string webComponentName)
        {
            this.GetWebComponent(webContainerName, webComponentName).PerformIfExists.Clear();
        }

        [When(@"user clears '(.+)-(.+)' if exists")]
        public void ActionClearIfExists(string webContainerName, string webComponentName, Table parameters)
        {
            foreach (var row in parameters.Rows)
            {
                this.GetWebComponent(webContainerName, webComponentName).With(row.Values.ToArray()).PerformIfExists.Clear();
            }
        }

        #endregion

        #region Click

        [When(@"user clicks '(.+)-(.+)'")]
        public void ActionClick(string webContainerName, string webComponentName)
        {
            this.GetWebComponent(webContainerName, webComponentName).Perform.Click();
        }

        [When(@"user clicks '(.+)-(.+)'")]
        public void ActionClick(string webContainerName, string webComponentName, Table parameters)
        {
            foreach (var row in parameters.Rows)
            {
                this.GetWebComponent(webContainerName, webComponentName).With(row.Values.ToArray()).Perform.Click();
            }
        }

        [When(@"user clicks '(.+)-(.+)' if exists")]
        public void ActionClickIfExists(string webContainerName, string webComponentName)
        {
            this.GetWebComponent(webContainerName, webComponentName).PerformIfExists.Click();
        }

        [When(@"user clicks '(.+)-(.+)' if exists")]
        public void ActionClickIfExists(string webContainerName, string webComponentName, Table parameters)
        {
            foreach (var row in parameters.Rows)
            {
                this.GetWebComponent(webContainerName, webComponentName).With(row.Values.ToArray()).PerformIfExists.Click();
            }
        }

        #endregion

        #region Click by script

        [When(@"user clicks by script '(.+)-(.+)'")]
        public void ActionClickByScript(string webContainerName, string webComponentName)
        {
            this.GetWebComponent(webContainerName, webComponentName).Perform.Click(ClickType.Script);
        }

        [When(@"user clicks by script '(.+)-(.+)'")]
        public void ActionClickByScript(string webContainerName, string webComponentName, Table parameters)
        {
            foreach (var row in parameters.Rows)
            {
                this.GetWebComponent(webContainerName, webComponentName).With(row.Values.ToArray()).Perform.Click(ClickType.Script);
            }
        }

        [When(@"user clicks by script '(.+)-(.+)' if exists")]
        public void ActionClickByScriptIfExists(string webContainerName, string webComponentName)
        {
            this.GetWebComponent(webContainerName, webComponentName).PerformIfExists.Click(ClickType.Script);
        }

        [When(@"user clicks by script '(.+)-(.+)' if exists")]
        public void ActionClickByScriptIfExists(string webContainerName, string webComponentName, Table parameters)
        {
            foreach (var row in parameters.Rows)
            {
                this.GetWebComponent(webContainerName, webComponentName).With(row.Values.ToArray()).PerformIfExists.Click(ClickType.Script);
            }
        }

        #endregion

        #region Click right button

        [When(@"user clicks right button on '(.+)-(.+)'")]
        public void ActionClickRight(string webContainerName, string webComponentName)
        {
            this.GetWebComponent(webContainerName, webComponentName).Perform.Click(ClickType.Right);
        }

        [When(@"user clicks right button on '(.+)-(.+)'")]
        public void ActionClickRight(string webContainerName, string webComponentName, Table parameters)
        {
            foreach (var row in parameters.Rows)
            {
                this.GetWebComponent(webContainerName, webComponentName).With(row.Values.ToArray()).Perform.Click(ClickType.Right);
            }
        }

        [When(@"user clicks right button on '(.+)-(.+)' if exists")]
        public void ActionClickRightfExists(string webContainerName, string webComponentName)
        {
            this.GetWebComponent(webContainerName, webComponentName).PerformIfExists.Click(ClickType.Right);
        }

        [When(@"user clicks right button on '(.+)-(.+)' if exists")]
        public void ActionClickRightIfExists(string webContainerName, string webComponentName, Table parameters)
        {
            foreach (var row in parameters.Rows)
            {
                this.GetWebComponent(webContainerName, webComponentName).With(row.Values.ToArray()).PerformIfExists.Click(ClickType.Right);
            }
        }

        #endregion

        #region Drag And Drop

        [When(@"user D&D '(.+)-(.+)' to '(.+)-(.+)'")]
        public void ActionDragAndDrop(string webContainerName, string webComponentName, string targetWebContainerName, string targetWebComponentName)
        {
            var targetWebComponent = this.GetWebComponent(targetWebContainerName, targetWebComponentName);
            this.GetWebComponent(webContainerName, webComponentName).Perform.DragAndDrop(targetWebComponent);
        }

        [When(@"user D&D '(.+)-(.+)' to '(.+)-(.+)'")]
        public void ActionDragAndDrop(string webContainerName, string webComponentName, string targetWebContainerName, string targetWebComponentName, Table parameters)
        {
            foreach (var row in parameters.Rows)
            {
                var targetWebComponent = this.GetWebComponent(targetWebContainerName, targetWebComponentName);
                this.GetWebComponent(webContainerName, webComponentName).With(row.Values.ToArray()).Perform.DragAndDrop(targetWebComponent);
            }
        }

        [When(@"user D&D '(.+)-(.+)' to '(.+)-(.+)' if exists")]
        public void ActionDragAndDropfExists(string webContainerName, string webComponentName, string targetWebContainerName, string targetWebComponentName)
        {
            var targetWebComponent = this.GetWebComponent(targetWebContainerName, targetWebComponentName);
            this.GetWebComponent(webContainerName, webComponentName).PerformIfExists.DragAndDrop(targetWebComponent);
        }

        [When(@"user D&D '(.+)-(.+)' to '(.+)-(.+)' if exists")]
        public void ActionDragAndDropIfExists(string webContainerName, string webComponentName, string targetWebContainerName, string targetWebComponentName, Table parameters)
        {
            foreach (var row in parameters.Rows)
            {
                var targetWebComponent = this.GetWebComponent(targetWebContainerName, targetWebComponentName);
                this.GetWebComponent(webContainerName, webComponentName).With(row.Values.ToArray()).PerformIfExists.DragAndDrop(targetWebComponent);
            }
        }

        #endregion

        #region Fill

        [When(@"user fills '(.+)-(.+)' with '(.*)'")]
        public void ActionFill(string webContainerName, string webComponentName, string text)
        {
            this.GetWebComponent(webContainerName, webComponentName).Perform.Fill(text);
        }

        [When(@"user fills '(.+)-(.+)' with '(.*)'")]
        public void ActionFill(string webContainerName, string webComponentName, string text, Table parameters)
        {
            foreach (var row in parameters.Rows)
            {
                this.GetWebComponent(webContainerName, webComponentName).With(row.Values.ToArray()).Perform.Fill(text);
            }
        }

        [When(@"user fills '(.+)-(.+)' with '(.*)' if exists")]
        public void ActionFillIfExists(string webContainerName, string webComponentName, string text)
        {
            this.GetWebComponent(webContainerName, webComponentName).PerformIfExists.Fill(text);
        }

        [When(@"user fills '(.+)-(.+)' with '(.*)' if exists")]
        public void ActionFillIfExists(string webContainerName, string webComponentName, string text, Table parameters)
        {
            foreach (var row in parameters.Rows)
            {
                this.GetWebComponent(webContainerName, webComponentName).With(row.Values.ToArray()).PerformIfExists.Fill(text);
            }
        }

        #endregion

        #region Fill by appending text

        [When(@"user fills by appending text '(.+)-(.+)' with '(.*)'")]
        public void ActionFillByAppendingText(string webContainerName, string webComponentName, string text)
        {
            this.GetWebComponent(webContainerName, webComponentName).Perform.Fill(text, FillType.AppendText);
        }

        [When(@"user fills by appending text '(.+)-(.+)' with '(.*)'")]
        public void ActionFillByAppendingText(string webContainerName, string webComponentName, string text, Table parameters)
        {
            foreach (var row in parameters.Rows)
            {
                this.GetWebComponent(webContainerName, webComponentName).With(row.Values.ToArray()).Perform.Fill(text, FillType.AppendText);
            }
        }

        [When(@"user fills by appending text '(.+)-(.+)' with '(.*)' if exists")]
        public void ActionFillByAppendingTextIfExists(string webContainerName, string webComponentName, string text)
        {
            this.GetWebComponent(webContainerName, webComponentName).PerformIfExists.Fill(text, FillType.AppendText);
        }

        [When(@"user fills by appending text '(.+)-(.+)' with '(.*)' if exists")]
        public void ActionFillByAppendingTextIfExists(string webContainerName, string webComponentName, string text, Table parameters)
        {
            foreach (var row in parameters.Rows)
            {
                this.GetWebComponent(webContainerName, webComponentName).With(row.Values.ToArray()).PerformIfExists.Fill(text, FillType.AppendText);
            }
        }

        #endregion

        #region Fill by sending text

        [When(@"user fills by sending text '(.+)-(.+)' with '(.*)'")]
        public void ActionFillBySendingText(string webContainerName, string webComponentName, string text)
        {
            this.GetWebComponent(webContainerName, webComponentName).Perform.Fill(text, FillType.SendKeys);
        }

        [When(@"user fills by sending text '(.+)-(.+)' with '(.*)'")]
        public void ActionFillBySendingText(string webContainerName, string webComponentName, string text, Table parameters)
        {
            foreach (var row in parameters.Rows)
            {
                this.GetWebComponent(webContainerName, webComponentName).With(row.Values.ToArray()).Perform.Fill(text, FillType.SendKeys);
            }
        }

        [When(@"user fills by sending text '(.+)-(.+)' with '(.*)' if exists")]
        public void ActionFillBySendingTextIfExists(string webContainerName, string webComponentName, string text)
        {
            this.GetWebComponent(webContainerName, webComponentName).PerformIfExists.Fill(text, FillType.SendKeys);
        }

        [When(@"user fills by sending text '(.+)-(.+)' with '(.*)' if exists")]
        public void ActionFillBySendingTextIfExists(string webContainerName, string webComponentName, string text, Table parameters)
        {
            foreach (var row in parameters.Rows)
            {
                this.GetWebComponent(webContainerName, webComponentName).With(row.Values.ToArray()).PerformIfExists.Fill(text, FillType.SendKeys);
            }
        }

        #endregion

        #region Hover

        [When(@"user hovers '(.+)-(.+)'")]
        public void ActionHover(string webContainerName, string webComponentName)
        {
            this.GetWebComponent(webContainerName, webComponentName).Perform.Hover();
        }

        [When(@"user hovers '(.+)-(.+)'")]
        public void ActionHover(string webContainerName, string webComponentName, Table parameters)
        {
            foreach (var row in parameters.Rows)
            {
                this.GetWebComponent(webContainerName, webComponentName).With(row.Values.ToArray()).Perform.Hover();
            }
        }

        [When(@"user hovers '(.+)-(.+)' if exists")]
        public void ActionHoverIfExists(string webContainerName, string webComponentName)
        {
            this.GetWebComponent(webContainerName, webComponentName).PerformIfExists.Hover();
        }

        [When(@"user hovers '(.+)-(.+)' if exists")]
        public void ActionHoverIfExists(string webContainerName, string webComponentName, Table parameters)
        {
            foreach (var row in parameters.Rows)
            {
                this.GetWebComponent(webContainerName, webComponentName).With(row.Values.ToArray()).PerformIfExists.Hover();
            }
        }

        #endregion

        #region Scroll

        [When(@"user scrolls to '(.+)-(.+)'")]
        public void ActionScroll(string webContainerName, string webComponentName)
        {
            this.GetWebComponent(webContainerName, webComponentName).Perform.Scroll();
        }

        [When(@"user scrolls to '(.+)-(.+)'")]
        public void ActionScroll(string webContainerName, string webComponentName, Table parameters)
        {
            foreach (var row in parameters.Rows)
            {
                this.GetWebComponent(webContainerName, webComponentName).With(row.Values.ToArray()).Perform.Scroll();
            }
        }

        [When(@"user scrolls to '(.+)-(.+)' if exists")]
        public void ActionScrollIfExists(string webContainerName, string webComponentName)
        {
            this.GetWebComponent(webContainerName, webComponentName).PerformIfExists.Scroll();
        }

        [When(@"user scrolls to '(.+)-(.+)' if exists")]
        public void ActionScrollIfExists(string webContainerName, string webComponentName, Table parameters)
        {
            foreach (var row in parameters.Rows)
            {
                this.GetWebComponent(webContainerName, webComponentName).With(row.Values.ToArray()).PerformIfExists.Scroll();
            }
        }

        #endregion

        #region Select by text

        [When(@"user selects by text '(.+)-(.+)' with '(.+)'")]
        public void ActionSelectByText(string webContainerName, string webComponentName, string text)
        {
            this.GetWebComponent(webContainerName, webComponentName).Perform.Select(text);
        }

        [When(@"user selects by text '(.+)-(.+)' with '(.+)'")]
        public void ActionSelectByText(string webContainerName, string webComponentName, string text, Table parameters)
        {
            foreach (var row in parameters.Rows)
            {
                this.GetWebComponent(webContainerName, webComponentName).With(row.Values.ToArray()).Perform.Select(text);
            }
        }

        [When(@"user selects by text '(.+)-(.+)' with '(.+)' if exists")]
        public void ActionSelectByTextIfExists(string webContainerName, string webComponentName, string text)
        {
            this.GetWebComponent(webContainerName, webComponentName).PerformIfExists.Select(text);
        }

        [When(@"user selects by text '(.+)-(.+)' with '(.+)' if exists")]
        public void ActionSelectByTextIfExists(string webContainerName, string webComponentName, string text, Table parameters)
        {
            foreach (var row in parameters.Rows)
            {
                this.GetWebComponent(webContainerName, webComponentName).With(row.Values.ToArray()).PerformIfExists.Select(text);
            }
        }

        #endregion

        #region Select by index

        [When(@"user selects by index '(.+)-(.+)' with '([0-9]+)'")]
        public void ActionSelectByIndex(string webContainerName, string webComponentName, int index)
        {
            this.GetWebComponent(webContainerName, webComponentName).Perform.Select(index);
        }

        [When(@"user selects by index '(.+)-(.+)' with '([0-9]+)'")]
        public void ActionSelectByIndex(string webContainerName, string webComponentName, int index, Table parameters)
        {
            foreach (var row in parameters.Rows)
            {
                this.GetWebComponent(webContainerName, webComponentName).With(row.Values.ToArray()).Perform.Select(index);
            }
        }

        [When(@"user selects by index '(.+)-(.+)' with '([0-9]+)' if exists")]
        public void ActionSelectByIndexIfExists(string webContainerName, string webComponentName, int index)
        {
            this.GetWebComponent(webContainerName, webComponentName).PerformIfExists.Select(index);
        }

        [When(@"user selects by index '(.+)-(.+)' with '([0-9]+)' if exists")]
        public void ActionSelectByIndexIfExists(string webContainerName, string webComponentName, int index, Table parameters)
        {
            foreach (var row in parameters.Rows)
            {
                this.GetWebComponent(webContainerName, webComponentName).With(row.Values.ToArray()).PerformIfExists.Select(index);
            }
        }

        #endregion

        #endregion

        #region Then (state)

        #region Present

        [Then(@"the '(.+)-(.+)' is present")]
        public void StateIsPresent(string webContainerName, string webComponentName)
        {
            this.GetWebComponent(webContainerName, webComponentName).Assert.Is.Present();
        }

        [Then(@"the '(.+)-(.+)' is present")]
        public void StateIsPresent(string webContainerName, string webComponentName, Table parameters)
        {
            foreach (var row in parameters.Rows)
            {
                this.GetWebComponent(webContainerName, webComponentName).With(row.Values.ToArray()).Assert.Is.Present();
            }
        }

        [Then(@"the '(.+)-(.+)' will be present")]
        public void StateWillBePresent(string webContainerName, string webComponentName)
        {
            this.GetWebComponent(webContainerName, webComponentName).Assert.WillBe.Present();
        }

        [Then(@"the '(.+)-(.+)' will be present")]
        public void StateWillBePresent(string webContainerName, string webComponentName, Table parameters)
        {
            foreach (var row in parameters.Rows)
            {
                this.GetWebComponent(webContainerName, webComponentName).With(row.Values.ToArray()).Assert.WillBe.Present();
            }
        }

        #endregion

        #region Not Present

        [Then(@"the '(.+)-(.+)' is not present")]
        public void StateIsNotPresent(string webContainerName, string webComponentName)
        {
            this.GetWebComponent(webContainerName, webComponentName).Assert.Is.NotPresent();
        }

        [Then(@"the '(.+)-(.+)' is not present")]
        public void StateIsNotPresent(string webContainerName, string webComponentName, Table parameters)
        {
            foreach (var row in parameters.Rows)
            {
                this.GetWebComponent(webContainerName, webComponentName).With(row.Values.ToArray()).Assert.Is.NotPresent();
            }
        }

        [Then(@"the '(.+)-(.+)' will be not present")]
        public void StateWillBeNotPresent(string webContainerName, string webComponentName)
        {
            this.GetWebComponent(webContainerName, webComponentName).Assert.WillBe.NotPresent();
        }

        [Then(@"the '(.+)-(.+)' will be not present")]
        public void StateWillBeNotPresent(string webContainerName, string webComponentName, Table parameters)
        {
            foreach (var row in parameters.Rows)
            {
                this.GetWebComponent(webContainerName, webComponentName).With(row.Values.ToArray()).Assert.WillBe.NotPresent();
            }
        }

        #endregion

        #region Displayed

        [Then(@"the '(.+)-(.+)' is displayed")]
        public void StateIsDisplayed(string webContainerName, string webComponentName)
        {
            this.GetWebComponent(webContainerName, webComponentName).Assert.Is.Displayed();
        }

        [Then(@"the '(.+)-(.+)' is displayed")]
        public void StateIsDisplayed(string webContainerName, string webComponentName, Table parameters)
        {
            foreach (var row in parameters.Rows)
            {
                this.GetWebComponent(webContainerName, webComponentName).With(row.Values.ToArray()).Assert.Is.Displayed();
            }
        }

        [Then(@"the '(.+)-(.+)' will be displayed")]
        public void StateWillBeDisplayed(string webContainerName, string webComponentName)
        {
            this.GetWebComponent(webContainerName, webComponentName).Assert.WillBe.Displayed();
        }

        [Then(@"the '(.+)-(.+)' will be displayed")]
        public void StateWillBeDisplayed(string webContainerName, string webComponentName, Table parameters)
        {
            foreach (var row in parameters.Rows)
            {
                this.GetWebComponent(webContainerName, webComponentName).With(row.Values.ToArray()).Assert.WillBe.Displayed();
            }
        }

        #endregion

        #region Not Displayed

        [Then(@"the '(.+)-(.+)' is not displayed")]
        public void StateIsNotDisplayed(string webContainerName, string webComponentName)
        {
            this.GetWebComponent(webContainerName, webComponentName).Assert.Is.NotDisplayed();
        }

        [Then(@"the '(.+)-(.+)' is not displayed")]
        public void StateIsNotDisplayed(string webContainerName, string webComponentName, Table parameters)
        {
            foreach (var row in parameters.Rows)
            {
                this.GetWebComponent(webContainerName, webComponentName).With(row.Values.ToArray()).Assert.Is.NotDisplayed();
            }
        }

        [Then(@"the '(.+)-(.+)' will be not displayed")]
        public void StateWillBeNotDisplayed(string webContainerName, string webComponentName)
        {
            this.GetWebComponent(webContainerName, webComponentName).Assert.WillBe.NotDisplayed();
        }

        [Then(@"the '(.+)-(.+)' will be not displayed")]
        public void StateWillBeNotDisplayed(string webContainerName, string webComponentName, Table parameters)
        {
            foreach (var row in parameters.Rows)
            {
                this.GetWebComponent(webContainerName, webComponentName).With(row.Values.ToArray()).Assert.WillBe.NotDisplayed();
            }
        }

        #endregion

        #region Checked

        [Then(@"the '(.+)-(.+)' is checked")]
        public void StateIsChecked(string webContainerName, string webComponentName)
        {
            this.GetWebComponent(webContainerName, webComponentName).Assert.Is.Checked();
        }

        [Then(@"the '(.+)-(.+)' is checked")]
        public void StateIsChecked(string webContainerName, string webComponentName, Table parameters)
        {
            foreach (var row in parameters.Rows)
            {
                this.GetWebComponent(webContainerName, webComponentName).With(row.Values.ToArray()).Assert.Is.Checked();
            }
        }

        [Then(@"the '(.+)-(.+)' will be checked")]
        public void StateWillBeChecked(string webContainerName, string webComponentName)
        {
            this.GetWebComponent(webContainerName, webComponentName).Assert.WillBe.Checked();
        }

        [Then(@"the '(.+)-(.+)' will be checked")]
        public void StateWillBeChecked(string webContainerName, string webComponentName, Table parameters)
        {
            foreach (var row in parameters.Rows)
            {
                this.GetWebComponent(webContainerName, webComponentName).With(row.Values.ToArray()).Assert.WillBe.Checked();
            }
        }

        #endregion

        #region Not Checked

        [Then(@"the '(.+)-(.+)' is not checked")]
        public void StateIsNotChecked(string webContainerName, string webComponentName)
        {
            this.GetWebComponent(webContainerName, webComponentName).Assert.Is.NotChecked();
        }

        [Then(@"the '(.+)-(.+)' is not checked")]
        public void StateIsNotChecked(string webContainerName, string webComponentName, Table parameters)
        {
            foreach (var row in parameters.Rows)
            {
                this.GetWebComponent(webContainerName, webComponentName).With(row.Values.ToArray()).Assert.Is.NotChecked();
            }
        }

        [Then(@"the '(.+)-(.+)' will be not checked")]
        public void StateWillBeNotChecked(string webContainerName, string webComponentName)
        {
            this.GetWebComponent(webContainerName, webComponentName).Assert.WillBe.NotChecked();
        }

        [Then(@"the '(.+)-(.+)' will be not checked")]
        public void StateWillBeNotChecked(string webContainerName, string webComponentName, Table parameters)
        {
            foreach (var row in parameters.Rows)
            {
                this.GetWebComponent(webContainerName, webComponentName).With(row.Values.ToArray()).Assert.WillBe.NotChecked();
            }
        }

        #endregion

        #region Enabled

        [Then(@"the '(.+)-(.+)' is enabled")]
        public void StateIsEnabled(string webContainerName, string webComponentName)
        {
            this.GetWebComponent(webContainerName, webComponentName).Assert.Is.Enabled();
        }

        [Then(@"the '(.+)-(.+)' is enabled")]
        public void StateIsEnabled(string webContainerName, string webComponentName, Table parameters)
        {
            foreach (var row in parameters.Rows)
            {
                this.GetWebComponent(webContainerName, webComponentName).With(row.Values.ToArray()).Assert.Is.Enabled();
            }
        }

        [Then(@"the '(.+)-(.+)' will be enabled")]
        public void StateWillBeEnabled(string webContainerName, string webComponentName)
        {
            this.GetWebComponent(webContainerName, webComponentName).Assert.WillBe.Enabled();
        }

        [Then(@"the '(.+)-(.+)' will be enabled")]
        public void StateWillBeEnabled(string webContainerName, string webComponentName, Table parameters)
        {
            foreach (var row in parameters.Rows)
            {
                this.GetWebComponent(webContainerName, webComponentName).With(row.Values.ToArray()).Assert.WillBe.Enabled();
            }
        }

        #endregion

        #region Not Enabled

        [Then(@"the '(.+)-(.+)' is not enabled")]
        public void StateIsNotEnabled(string webContainerName, string webComponentName)
        {
            this.GetWebComponent(webContainerName, webComponentName).Assert.Is.NotEnabled();
        }

        [Then(@"the '(.+)-(.+)' is not enabled")]
        public void StateIsNotEnabled(string webContainerName, string webComponentName, Table parameters)
        {
            foreach (var row in parameters.Rows)
            {
                this.GetWebComponent(webContainerName, webComponentName).With(row.Values.ToArray()).Assert.Is.NotEnabled();
            }
        }

        [Then(@"the '(.+)-(.+)' will be not enabled")]
        public void StateWillBeNotEnabled(string webContainerName, string webComponentName)
        {
            this.GetWebComponent(webContainerName, webComponentName).Assert.WillBe.NotEnabled();
        }

        [Then(@"the '(.+)-(.+)' will be not enabled")]
        public void StateWillBeNotEnabled(string webContainerName, string webComponentName, Table parameters)
        {
            foreach (var row in parameters.Rows)
            {
                this.GetWebComponent(webContainerName, webComponentName).With(row.Values.ToArray()).Assert.WillBe.NotEnabled();
            }
        }

        #endregion

        #endregion

        #region Then (value)

        #region Text

        [Then(@"the '(.+)-(.+)' has text (equal to|not equal to|which contains|which not contains|which starts with|which ends with) '(.*)'")]
        public void ValueHasTextEqualTo(string webContainerName, string webComponentName, string comparisonType, string text)
        {
            this.GetWebComponent(webContainerName, webComponentName).Assert.Has.Text(text, StringTypes[comparisonType]);
        }

        [Then(@"the '(.+)-(.+)' has text (equal to|not equal to|which contains|which not contains|which starts with|which ends with) '(.*)'")]
        public void ValueHasTextEqualTo(string webContainerName, string webComponentName, string comparisonType, string text, Table parameters)
        {
            foreach (var row in parameters.Rows)
            {
                this.GetWebComponent(webContainerName, webComponentName).With(row.Values.ToArray()).Assert.Has.Text(text, StringTypes[comparisonType]);
            }
        }

        [Then(@"the '(.+)-(.+)' will have text (equal to|not equal to|which contains|which not contains|which starts with|which ends with) '(.*)'")]
        public void ValueWillHaveTextEqualTo(string webContainerName, string webComponentName, string comparisonType, string text)
        {
            this.GetWebComponent(webContainerName, webComponentName).Assert.WillHave.Text(text, StringTypes[comparisonType]);
        }

        [Then(@"the '(.+)-(.+)' will have text (equal to|not equal to|which contains|which not contains|which starts with|which ends with) '(.*)'")]
        public void ValueWillHaveTextEqualTo(string webContainerName, string webComponentName, string comparisonType, string text, Table parameters)
        {
            foreach (var row in parameters.Rows)
            {
                this.GetWebComponent(webContainerName, webComponentName).With(row.Values.ToArray()).Assert.WillHave.Text(text, StringTypes[comparisonType]);
            }
        }

        #endregion

        #region Value

        [Then(@"the '(.+)-(.+)' has value (equal to|not equal to|which contains|which not contains|which starts with|which ends with) '(.*)'")]
        public void ValueHasValueEqualTo(string webContainerName, string webComponentName, string comparisonType, string value)
        {
            this.GetWebComponent(webContainerName, webComponentName).Assert.Has.Value(value, StringTypes[comparisonType]);
        }

        [Then(@"the '(.+)-(.+)' has value (equal to|not equal to|which contains|which not contains|which starts with|which ends with) '(.*)'")]
        public void ValueHasValueEqualTo(string webContainerName, string webComponentName, string comparisonType, string value, Table parameters)
        {
            foreach (var row in parameters.Rows)
            {
                this.GetWebComponent(webContainerName, webComponentName).With(row.Values.ToArray()).Assert.Has.Value(value, StringTypes[comparisonType]);
            }
        }

        [Then(@"the '(.+)-(.+)' will have value (equal to|not equal to|which contains|which not contains|which starts with|which ends with) '(.*)'")]
        public void ValueWillHaveValueEqualTo(string webContainerName, string webComponentName, string comparisonType, string value)
        {
            this.GetWebComponent(webContainerName, webComponentName).Assert.WillHave.Value(value, StringTypes[comparisonType]);
        }

        [Then(@"the '(.+)-(.+)' will have value (equal to|not equal to|which contains|which not contains|which starts with|which ends with) '(.*)'")]
        public void ValueWillHaveValueEqualTo(string webContainerName, string webComponentName, string comparisonType, string value, Table parameters)
        {
            foreach (var row in parameters.Rows)
            {
                this.GetWebComponent(webContainerName, webComponentName).With(row.Values.ToArray()).Assert.WillHave.Value(value, StringTypes[comparisonType]);
            }
        }

        #endregion

        #region Text length

        [Then(@"the '(.+)-(.+)' has text length (equal to|not equal to|greater than|greater than or equal to|less than|less than or equal to) '([0-9]+)'")]
        public void ValueHasTextLengthEqualTo(string webContainerName, string webComponentName, string comparisonType, int count)
        {
            this.GetWebComponent(webContainerName, webComponentName).Assert.Has.TextLength(count, NumericTypes[comparisonType]);
        }

        [Then(@"the '(.+)-(.+)' has text length (equal to|not equal to|greater than|greater than or equal to|less than|less than or equal to) '([0-9]+)'")]
        public void ValueHasTextLengthEqualTo(string webContainerName, string webComponentName, string comparisonType, int count, Table parameters)
        {
            foreach (var row in parameters.Rows)
            {
                this.GetWebComponent(webContainerName, webComponentName).With(row.Values.ToArray()).Assert.Has.TextLength(count, NumericTypes[comparisonType]);
            }
        }

        [Then(@"the '(.+)-(.+)' will have text length (equal to|not equal to|greater than|greater than or equal to|less than|less than or equal to) '([0-9]+)'")]
        public void ValueWillHaveTextLengthEqualTo(string webContainerName, string webComponentName, string comparisonType, int count)
        {
            this.GetWebComponent(webContainerName, webComponentName).Assert.WillHave.TextLength(count, NumericTypes[comparisonType]);
        }

        [Then(@"the '(.+)-(.+)' will have text length (equal to|not equal to|greater than|greater than or equal to|less than|less than or equal to) '([0-9]+)'")]
        public void ValueWillHaveTextLengthEqualTo(string webContainerName, string webComponentName, string comparisonType, int count, Table parameters)
        {
            foreach (var row in parameters.Rows)
            {
                this.GetWebComponent(webContainerName, webComponentName).With(row.Values.ToArray()).Assert.WillHave.TextLength(count, NumericTypes[comparisonType]);
            }
        }

        #endregion

        #region Value length

        [Then(@"the '(.+)-(.+)' has value length (equal to|not equal to|greater than|greater than or equal to|less than|less than or equal to) '([0-9]+)'")]
        public void ValueHasValueLengthEqualTo(string webContainerName, string webComponentName, string comparisonType, int count)
        {
            this.GetWebComponent(webContainerName, webComponentName).Assert.Has.ValueLength(count, NumericTypes[comparisonType]);
        }

        [Then(@"the '(.+)-(.+)' has value length (equal to|not equal to|greater than|greater than or equal to|less than|less than or equal to) '([0-9]+)'")]
        public void ValueHasValueLengthEqualTo(string webContainerName, string webComponentName, string comparisonType, int count, Table parameters)
        {
            foreach (var row in parameters.Rows)
            {
                this.GetWebComponent(webContainerName, webComponentName).With(row.Values.ToArray()).Assert.Has.ValueLength(count, NumericTypes[comparisonType]);
            }
        }

        [Then(@"the '(.+)-(.+)' will have value length (equal to|not equal to|greater than|greater than or equal to|less than|less than or equal to) '([0-9]+)'")]
        public void ValueWillHaveValueLengthEqualTo(string webContainerName, string webComponentName, string comparisonType, int count)
        {
            this.GetWebComponent(webContainerName, webComponentName).Assert.WillHave.ValueLength(count, NumericTypes[comparisonType]);
        }

        [Then(@"the '(.+)-(.+)' will have value length (equal to|not equal to|greater than|greater than or equal to|less than|less than or equal to) '([0-9]+)'")]
        public void ValueWillHaveValueLengthEqualTo(string webContainerName, string webComponentName, string comparisonType, int count, Table parameters)
        {
            foreach (var row in parameters.Rows)
            {
                this.GetWebComponent(webContainerName, webComponentName).With(row.Values.ToArray()).Assert.WillHave.ValueLength(count, NumericTypes[comparisonType]);
            }
        }

        #endregion

        #region Option

        [Then(@"the '(.+)-(.+)' has option '(.+)' (selected|not selected|available|not available)")]
        public void ValueHasOption(string webContainerName, string webComponentName, string optionValue, string selectionType)
        {
            this.GetWebComponent(webContainerName, webComponentName).Assert.Has.Option(optionValue, OptionTypes[selectionType]);
        }

        [Then(@"the '(.+)-(.+)' has option '(.+)' (selected|not selected|available|not available)")]
        public void ValueHasOption(string webContainerName, string webComponentName, string optionValue, string selectionType, Table parameters)
        {
            foreach (var row in parameters.Rows)
            {
                this.GetWebComponent(webContainerName, webComponentName).With(row.Values.ToArray()).Assert.Has.Option(optionValue, OptionTypes[selectionType]);
            }
        }

        [Then(@"the '(.+)-(.+)' will have option '(.+)' (selected|not selected|available|not available)")]
        public void ValueWillHaveOption(string webContainerName, string webComponentName, string optionValue, string selectionType)
        {
            this.GetWebComponent(webContainerName, webComponentName).Assert.WillHave.Option(optionValue, OptionTypes[selectionType]);
        }

        [Then(@"the '(.+)-(.+)' will have option '(.+)' (selected|not selected|available|not available)")]
        public void ValueWillHaveOption(string webContainerName, string webComponentName, string optionValue, string selectionType, Table parameters)
        {
            foreach (var row in parameters.Rows)
            {
                this.GetWebComponent(webContainerName, webComponentName).With(row.Values.ToArray()).Assert.WillHave.Option(optionValue, OptionTypes[selectionType]);
            }
        }

        #endregion

        #region CSS

        [Then(@"the '(.+)-(.+)' has CSS attribute '(.+)' with value (equal to|not equal to|which contains|which not contains|which starts with|which ends with) '(.*)'")]
        public void ValueHasCSS(string webContainerName, string webComponentName, string cssAttributeName, string comparisonType, string value)
        {
            this.GetWebComponent(webContainerName, webComponentName).Assert.Has.CssValue(cssAttributeName, value, StringTypes[comparisonType]);
        }

        [Then(@"the '(.+)-(.+)' has CSS attribute '(.+)' with value (equal to|not equal to|which contains|which not contains|which starts with|which ends with) '(.*)'")]
        public void ValueHasCSS(string webContainerName, string webComponentName, string cssAttributeName, string comparisonType, string value, Table parameters)
        {
            foreach (var row in parameters.Rows)
            {
                this.GetWebComponent(webContainerName, webComponentName).With(row.Values.ToArray()).Assert.Has.CssValue(cssAttributeName, value, StringTypes[comparisonType]);
            }
        }

        [Then(@"the '(.+)-(.+)' will have CSS attribute '(.+)' with value (equal to|not equal to|which contains|which not contains|which starts with|which ends with) '(.*)'")]
        public void ValueWillHaveCSS(string webContainerName, string webComponentName, string cssAttributeName, string comparisonType, string value)
        {
            this.GetWebComponent(webContainerName, webComponentName).Assert.WillHave.CssValue(cssAttributeName, value, StringTypes[comparisonType]);
        }

        [Then(@"the '(.+)-(.+)' will have CSS attribute '(.+)' with value (equal to|not equal to|which contains|which not contains|which starts with|which ends with) '(.*)'")]
        public void ValueWillHaveCSS(string webContainerName, string webComponentName, string cssAttributeName, string comparisonType, string value, Table parameters)
        {
            foreach (var row in parameters.Rows)
            {
                this.GetWebComponent(webContainerName, webComponentName).With(row.Values.ToArray()).Assert.WillHave.CssValue(cssAttributeName, value, StringTypes[comparisonType]);
            }
        }

        #endregion

        #region Attribute

        [Then(@"the '(.+)-(.+)' has attribute '(.+)' with value (equal to|not equal to|which contains|which not contains|which starts with|which ends with) '(.*)'")]
        public void ValueHasAttribute(string webContainerName, string webComponentName, string attributeName, string comparisonType, string value)
        {
            this.GetWebComponent(webContainerName, webComponentName).Assert.Has.AttributeValue(attributeName, value, StringTypes[comparisonType]);
        }

        [Then(@"the '(.+)-(.+)' has attribute '(.+)' with value (equal to|not equal to|which contains|which not contains|which starts with|which ends with) '(.*)'")]
        public void ValueHasAttribute(string webContainerName, string webComponentName, string attributeName, string comparisonType, string value, Table parameters)
        {
            foreach (var row in parameters.Rows)
            {
                this.GetWebComponent(webContainerName, webComponentName).With(row.Values.ToArray()).Assert.Has.AttributeValue(attributeName, value, StringTypes[comparisonType]);
            }
        }

        [Then(@"the '(.+)-(.+)' will have attribute '(.+)' with value (equal to|not equal to|which contains|which not contains|which starts with|which ends with) '(.*)'")]
        public void ValueWillHaveAttribute(string webContainerName, string webComponentName, string attributeName, string comparisonType, string value)
        {
            this.GetWebComponent(webContainerName, webComponentName).Assert.WillHave.AttributeValue(attributeName, value, StringTypes[comparisonType]);
        }

        [Then(@"the '(.+)-(.+)' will have attribute '(.+)' with value (equal to|not equal to|which contains|which not contains|which starts with|which ends with) '(.*)'")]
        public void ValueWillHaveAttribute(string webContainerName, string webComponentName, string attributeName, string comparisonType, string value, Table parameters)
        {
            foreach (var row in parameters.Rows)
            {
                this.GetWebComponent(webContainerName, webComponentName).With(row.Values.ToArray()).Assert.WillHave.AttributeValue(attributeName, value, StringTypes[comparisonType]);
            }
        }

        #endregion

        #region Elements number

        [Then(@"the '(.+)-(.+)' has elements count (equal to|not equal to|greater than|greater than or equal to|less than|less than or equal to) '([0-9]+)'")]
        public void ValueHasElementsCount(string webContainerName, string webComponentName, string comparisonType, int count)
        {
            this.GetWebComponent(webContainerName, webComponentName).Assert.Has.ElementsNumber(count, NumericTypes[comparisonType]);
        }

        [Then(@"the '(.+)-(.+)' has elements count (equal to|not equal to|greater than|greater than or equal to|less than|less than or equal to) '([0-9]+)'")]
        public void ValueHasElementsCount(string webContainerName, string webComponentName, string comparisonType, int count, Table parameters)
        {
            foreach (var row in parameters.Rows)
            {
                this.GetWebComponent(webContainerName, webComponentName).With(row.Values.ToArray()).Assert.Has.ElementsNumber(count, NumericTypes[comparisonType]);
            }
        }

        [Then(@"the '(.+)-(.+)' will have elements count (equal to|not equal to|greater than|greater than or equal to|less than|less than or equal to) '([0-9]+)'")]
        public void ValueWillHaveElementsCount(string webContainerName, string webComponentName, string comparisonType, int count)
        {
            this.GetWebComponent(webContainerName, webComponentName).Assert.WillHave.ElementsNumber(count, NumericTypes[comparisonType]);
        }

        [Then(@"the '(.+)-(.+)' will have elements count (equal to|not equal to|greater than|greater than or equal to|less than|less than or equal to) '([0-9]+)'")]
        public void ValueWillHaveElementsCount(string webContainerName, string webComponentName, string comparisonType, int count, Table parameters)
        {
            foreach (var row in parameters.Rows)
            {
                this.GetWebComponent(webContainerName, webComponentName).With(row.Values.ToArray()).Assert.WillHave.ElementsNumber(count, NumericTypes[comparisonType]);
            }
        }

        #endregion

        #region Elements sorted alphabetically

        [Then(@"the '(.+)-(.+)' has elements sorted alphabetically")]
        public void ValueHasElementsSorted(string webContainerName, string webComponentName)
        {
            this.GetWebComponent(webContainerName, webComponentName).Assert.Has.ElementsSortedByText();
        }

        [Then(@"the '(.+)-(.+)' has elements sorted alphabetically")]
        public void ValueHasElementsSorted(string webContainerName, string webComponentName, Table parameters)
        {
            foreach (var row in parameters.Rows)
            {
                this.GetWebComponent(webContainerName, webComponentName).With(row.Values.ToArray()).Assert.Has.ElementsSortedByText();
            }
        }

        [Then(@"the '(.+)-(.+)' will have elements sorted alphabetically")]
        public void ValueWillHaveElementsSorted(string webContainerName, string webComponentName)
        {
            this.GetWebComponent(webContainerName, webComponentName).Assert.WillHave.ElementsSortedByText();
        }

        [Then(@"the '(.+)-(.+)' will have elements sorted alphabetically")]
        public void ValueWillHaveElementsSorted(string webContainerName, string webComponentName, Table parameters)
        {
            foreach (var row in parameters.Rows)
            {
                this.GetWebComponent(webContainerName, webComponentName).With(row.Values.ToArray()).Assert.WillHave.ElementsSortedByText();
            }
        }

        #endregion

        #endregion
    }
}
