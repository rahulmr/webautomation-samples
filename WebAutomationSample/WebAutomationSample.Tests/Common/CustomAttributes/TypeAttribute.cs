using WebAutomation.Core.WebObjects.WebComponents.Attributes;

namespace WebAutomationSample.Tests.Common.CustomAttributes
{
    /// <summary>
    /// Type attribute.
    /// Can be used in generic steps, where we are finding WebComponent by reflection and we are not aware of its type.
    /// </summary>
    public class TypeAttribute : WebComponentAttribute
    {
        public string Type { get; set; }

        public TypeAttribute(string type)
        {
            this.Type = type;
        }
    }
}
