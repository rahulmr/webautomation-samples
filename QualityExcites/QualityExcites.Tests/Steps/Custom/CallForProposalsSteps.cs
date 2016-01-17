using TechTalk.SpecFlow;
using WebAutomation.Core.WebObjects.WebComponents;
using WebAutomation.Core.WebObjects.WebComponents.Value;
using QualityExcites.Tests.Common;
using QualityExcites.Tests.Pages;

namespace QualityExcites.Tests.Steps.Custom
{
    [Binding]
    public class CallForProposalsSteps : SpecFlowTest
    {
        protected CallForProposalsPage Page
        {
            get
            {
                return this.GetContainer<CallForProposalsPage>();
            }
        }

        [Then(@"User is successfully registered")]
        public void ThenUserIsSuccessfullyRegistered()
        {
            this.GetContainer<CallForProposalsPage>().Header.Assert.WillHave.Text("THANK YOU");
        }

        /// <summary>
        /// This kind of step can be also implemented in a generic way (to be reusable in many pages).
        /// See "User fills following fields on '(.*)' page"
        /// 
        /// For demonstration purposes, current implementation is dedicated only for "CallForProposalsPage"
        /// </summary>
        [Then(@"All fields from step (.*) are marked as invalid")]
        public void ThenAllFieldsFromStepAreMarkedAsInvalid(int step)
        {
            var stepComponents = step == 1 
                ? new IWebComponent[]
                    {
                        this.Page.Title,
                        this.Page.Description,
                        this.Page.Speaker.With("yes"),
                        this.Page.Presented.With("yes")
                    }
                : new IWebComponent[]
                    {
                        this.Page.FirstName,
                        this.Page.Surname,
                        this.Page.Position,
                        this.Page.CompanyInstitution,
                        this.Page.EmailAddress,
                        this.Page.PhoneNumber,
                        this.Page.Biography,
                        this.Page.Agreement,
                        this.Page.Captcha,
                        this.Page.Photo
                    };

            foreach (var webComponent in stepComponents)
            {
                webComponent.Assert.Has.AttributeValue("class", "not-valid", StringType.Contains);
            }
        }
    }
}
