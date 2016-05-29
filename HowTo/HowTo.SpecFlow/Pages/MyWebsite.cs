

// ------------------------------------------------------------------------------
//  <auto-generated>
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated. 
//  </auto-generated>
// ------------------------------------------------------------------------------

#region Designer generated code
#pragma warning disable

namespace HowTo.SpecFlow.Pages.MyWebSite
{
	using WebAutomation.Core.WebObjects.Common.Attributes;
	using WebAutomation.Core.WebObjects.WebComponents;
	using WebAutomation.Core.WebObjects.WebComponents.Attributes;
	using WebAutomation.Core.WebObjects.WebContainer;
	using WebAutomation.Core.WebObjects.WebContainer.Attributes;

	[Name("MyWebsite")]
	public partial class MyWebsite 
	{
		[Name("Menu")]
		[Xpath("//ul[@id='menu']")]
		public IWebComponent Menu { get; set; }

		[Name("MenuHomeButton")]
		[Xpath("//ul[@id='menu']/li/a[text()='Home']")]
		public IWebComponent MenuHomeButton { get; set; }

		[Name("MenuNewsButton")]
		[Xpath("//ul[@id='menu']/li/a[text()='News']")]
		public IWebComponent MenuNewsButton { get; set; }

		[Name("MenuLoginButton")]
		[Xpath("//ul[@id='menu']/li/a[text()='Login']")]
		public IWebComponent MenuLoginButton { get; set; }

	}

	[Name("HomePage")]
	public partial class HomePage : MyWebsite
	{
	}

	[Name("LoginPage")]
	public partial class LoginPage : MyWebsite
	{
		[Name("UserTextbox")]
		[Id("user")]
		public IWebComponent UserTextbox { get; set; }

		[Name("PasswordTextbox")]
		[Id("password")]
		public IWebComponent PasswordTextbox { get; set; }

		[Name("LoginButton")]
		[Id("login")]
		public IWebComponent LoginButton { get; set; }

		[Name("Message")]
		[Id("message")]
		public IWebComponent Message { get; set; }

	}

	[Name("NewsPage")]
	public partial class NewsPage : MyWebsite
	{
		[Name("TableRow")]
		[Pxpath("//table/tbody/tr[{0}]")]
		public IWebComponent TableRow { get; set; }

		[Name("TableRowByValues")]
		[Pxpath("//table/tbody/tr[{0}][./td[1][text()='{1}']][./td[2][text()='{2}']][./td[3]/div[contains(text(), '{3}')]]")]
		public IWebComponent TableRowByValues { get; set; }

		[Name("TableRowId")]
		[Pxpath("//table/tbody/tr[{0}]/td[1]")]
		public IWebComponent TableRowId { get; set; }

		[Name("TableRowTitle")]
		[Pxpath("//table/tbody/tr[{0}]/td[2]")]
		public IWebComponent TableRowTitle { get; set; }

		[Name("TableRowContent")]
		[Pxpath("//table/tbody/tr[{0}]/td[3]/div")]
		public IWebComponent TableRowContent { get; set; }

	}

}

#pragma warning restore
#endregion

