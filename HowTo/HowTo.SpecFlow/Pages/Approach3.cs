

// ------------------------------------------------------------------------------
//  <auto-generated>
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated. 
//  </auto-generated>
// ------------------------------------------------------------------------------

#region Designer generated code
#pragma warning disable

namespace HowTo.SpecFlow.Pages.Approach3
{
	using WebAutomation.Core.WebObjects.Common.Attributes;
	using WebAutomation.Core.WebObjects.WebComponents;
	using WebAutomation.Core.WebObjects.WebComponents.Attributes;
	using WebAutomation.Core.WebObjects.WebContainer;
	using WebAutomation.Core.WebObjects.WebContainer.Attributes;

	[Name("GenericPage")]
	public partial class GenericPage 
	{
		[Name("Link")]
		[Pxpath("//a[text()='{0}']")]
		public IWebComponent Link { get; set; }

		[Name("Textbox")]
		[Pid("{0}")]
		public IWebComponent Textbox { get; set; }

		[Name("Button")]
		[Pxpath("//button[text()='{0}']")]
		public IWebComponent Button { get; set; }

		[Name("Message")]
		[Pxpath("//*[text()='{0}']")]
		public IWebComponent Message { get; set; }

		[Name("TableHeader")]
		[Xpath("//table/thead/tr/th")]
		public IWebComponent TableHeader { get; set; }

		[Name("TableRowCell")]
		[Pxpath("//table/tbody/tr[{0}]/td[{1}]")]
		public IWebComponent TableRowCell { get; set; }

	}

}

#pragma warning restore
#endregion

