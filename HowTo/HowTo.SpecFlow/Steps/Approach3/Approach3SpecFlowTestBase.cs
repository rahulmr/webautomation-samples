using HowTo.SpecFlow.Pages.Approach3;
using System;
using WebAutomation.Core.WebObjects.WebComponents;
using WebAutomation.SpecFlow;

namespace HowTo.SpecFlow.Steps.Approach3
{
    public class Approach3SpecFlowTestBase : SpecFlowTestBase
    {
        protected GenericPage Page
        {
            get
            {
                return this.GetContainer<GenericPage>();
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
