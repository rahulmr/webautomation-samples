using System;
using System.IO;
using TechTalk.SpecFlow;
using WebAutomation.Core;
using WebAutomation.Core.WebObjects.WebComponents.Actions;
using WebAutomationSample.Tests.Common;
using WebAutomationSample.Tests.Pages;

namespace WebAutomationSample.Tests.Steps
{
    [Binding]
    public class CallForProposalsSteps : SpecFlowTest
    {
        public CallForProposalsPage Page
        {
            get
            {
                return this.GetContainer<CallForProposalsPage>();
            }
        }

        [When(@"User fills '(.+)' field with '([0-9]+)' characters")]
        public void WhenUserFillsFollowingFields(string fieldName, int numberOfCharacters)
        {
            string value = new string('I', numberOfCharacters);

            switch (fieldName)
            {
                case "title":
                    this.Page.TitleInput.Perform.Fill(value);
                    break;

                case "description":
                    this.Page.DescriptionInput.Perform.Fill(value);
                    break;

                default:
                    throw new ArgumentException("Field not supported");
            }
        }

        [When(@"User fills following fields")]
        public void WhenUserFillsFollowingFields(Table table)
        {
            foreach (var field in table.Rows)
            {
                string name = field["name"];
                string value = field["value"];

                switch (name)
                {
                    case "title":
                        this.Page.TitleInput.Perform.Fill(value);
                        break;

                    case "description":
                        this.Page.DescriptionInput.Perform.Fill(value);
                        break;

                    case "form":
                        this.Page.FormSelect.Perform.Select(value);
                        break;

                    case "speaker":
                        this.Page.SpeakerOption.With(value).Perform.Click();
                        break;

                    case "presented":
                        this.Page.PresentedOption.With(value).Perform.Click();
                        break;

                    case "file":
                        var path = Path.Combine(TestBase.AssemblyDirectory, "Resources", value);
                        this.Page.Upload.Perform.Fill(path, FillType.SendKeys);
                        break;

                    default:
                        throw new ArgumentException("Field not supported");
                }
            }
        }


    }
}
