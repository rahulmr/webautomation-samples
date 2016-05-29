using HowTo.SpecFlow.Pages.Approach3;
using System;
using System.Linq;
using TechTalk.SpecFlow;
using WebAutomation.Core.WebObjects.WebComponents;
using WebAutomation.Core.WebObjects.WebComponents.Value;
using WebAutomation.SpecFlow;

namespace HowTo.SpecFlow.Steps.Approach1
{
    [Binding]
    public class Approach3Steps : SpecFlowTestBase
    {
        protected GenericPage Page
        {
            get
            {
                return this.GetContainer<GenericPage>();
            }
        }

        [When(@"I click on ""(.*)"" (link|button)")]
        public void WhenIClick(string name, string type)
        {
            GetWebComponent(type, name).Perform.Click();
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

        protected IWebComponent GetWebComponent(string type, params string[] parameters)
        {
            switch (type)
            {
                case "link":
                    return Page.Link.With(parameters);
                case "button":
                    return Page.Button.With(parameters);
                default:
                    throw new ArgumentException($"Incorrect type '{type}'");
            }
        }
    }
}
