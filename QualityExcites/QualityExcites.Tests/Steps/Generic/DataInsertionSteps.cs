using System;
using System.IO;
using TechTalk.SpecFlow;
using WebAutomation.Core;
using WebAutomation.Core.WebObjects.WebComponents.Actions;
using QualityExcites.Tests.Common;
using QualityExcites.Tests.Common.Extensions;

namespace QualityExcites.Tests.Steps.Common
{
    /// <summary>
    /// Generic stps for filling fields.
    /// Components can be found (in XML) only by using reflection mechanism. 
    /// For page-specific operations, you should rather create custom steps that will use only strongly typed objects: "this.GetContainer<PageName>().ElementName"
    /// </summary>
    [Binding]
    public class DataInsertionSteps : SpecFlowTest
    {
        /// <summary>
        /// Generic steps for filling fields.
        /// Type of fields is retrieved by using custom attribute "type"
        /// </summary>
        /// <param name="pageName">The name of page.</param>
        /// <param name="table">List of fields to fill.</param>
        [When(@"User fills following fields on '(.*)' page")]
        public void WhenUserFillsFollowingFieldsOnPage(string pageName, Table table)
        {
            string webContainerName = string.Format("{0}Page", pageName.ToCamelCase());

            foreach (var field in table.Rows)
            {
                string webComponentName = field["name"].ToCamelCase();
                string value = field["value"]; 

                // Get Web Component by reflection
                var webComponent = this.GetWebComponent(webContainerName, webComponentName);

                // Web Component has been found by reflection (it is not strongly typed)
                // So to recognise its purpose, we added custom attribute "type" in the XML
                switch (webComponent.Properties["type"])
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
                        webComponent.Perform.Check();
                        break;

                    default:
                        throw new ArgumentException("Incorrect type: " + webComponent.Properties["type"]);
                }
            }
        }
    }
}
