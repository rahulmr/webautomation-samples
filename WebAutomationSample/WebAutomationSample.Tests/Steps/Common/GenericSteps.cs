using System;
using System.IO;
using TechTalk.SpecFlow;
using WebAutomation.Core;
using WebAutomation.Core.WebObjects.WebComponents.Actions;
using WebAutomationSample.Tests.Common;
using WebAutomationSample.Tests.Common.Extensions;

namespace WebAutomationSample.Tests.Steps.Common
{
    /// <summary>
    /// Custom generic steps.
    /// Here are steps that can be used on all pages.
    /// Components can be found (in XML) only by using reflection mechanism. 
    /// For page-specific operations, you should create new steps that will use only strongly typed objects: "this.GetContainer<PageName>().ElementName"
    /// </summary>
    [Binding]
    public class GenericSteps : SpecFlowTest
    {
        [When(@"User fills following fields on '(.*)' page")]
        public void WhenUserFillsFollowingFieldsOnPage(string pageName, Table table)
        {
            string webContainerName = string.Format("{0}Page", pageName.ToCamelCase());

            foreach (var field in table.Rows)
            {
                string webComponentName = field["name"].ToCamelCase();
                string value = field["value"];
                string type = string.IsNullOrEmpty(field["type"]) ? "text" : field["type"]; 

                // Get Web Component by reflection
                var webComponent = this.GetWebComponent(webContainerName, webComponentName);

                switch (type)
                {
                    case "text":
                        webComponent.Perform.Fill(value);
                        break;

                    case "characters":
                        value = new string('I', int.Parse(value));
                        webComponent.Perform.Fill(value, FillType.SendKeys);
                        break;

                    case "file":
                        var filePath = Path.Combine(TestBase.AssemblyDirectory, "Resources", value);
                        webComponent.Perform.Fill(filePath, FillType.SendKeys);
                        break;

                    case "select":
                        webComponent.Perform.Select(value);
                        break;

                    case "radio":
                        webComponent.With(value).Perform.Click();
                        break;

                    case "checkbox":
                        webComponent.Perform.Click();
                        break;

                    default:
                        throw new ArgumentException("Incorrect type: " + type);
                }
            }
        }
    }
}
