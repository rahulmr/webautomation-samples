using System;
using System.Linq;
using TechTalk.SpecFlow;
using WebAutomation.Core.WebObjects.WebComponents;
using WebAutomation.Core.WebObjects.WebComponents.Value;

namespace HowTo.SpecFlow.Steps.Approach3
{
    [Binding]
    public class Approach3Steps : Approach3SpecFlowTestBase
    {
        [When(@"I click on ""(.*)"" (link|button)")]
        public void WhenIClick(string name, string type)
        {
            GetWebComponent(type, name).Perform.Click();
        }

        [When(@"I fill following fields:")]
        public void WhenIFillFollowingFields(Table table)
        {
            foreach (var field in table.Rows)
            {
                Page.Textbox
                    .With(field["name"])
                    .Perform.Fill(field["value"]);
            }
        }

        [Then(@"table is displayed")]
        public void ThenTableIsDisplayed(Table table)
        {
            var headers = Page.TableHeader
                              .WebElementProvider
                              .WebElements
                              .Select(e => e.Text)
                              .ToList();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                foreach (var header in table.Header)
                {
                    var rowIndex = i;
                    var cellIndex = headers.IndexOf(header);
                    var value = table.Rows[rowIndex][cellIndex];

                    Page.TableRowCell
                        .With(
                            (rowIndex + 1).ToString(),
                            (cellIndex + 1).ToString())
                        .Assert
                        .Has.Text(value, StringType.Contains);
                }
            }
        }

        [Then(@"""(.*)"" (message|text|warning) is displayed")]
        public void ThenMessageIsDisplayed(string text, string type)
        {
            // 'type' parameter - not used in current implementation
            Page.Message.With(text).Assert.Is.Displayed();
        }
    }
}
