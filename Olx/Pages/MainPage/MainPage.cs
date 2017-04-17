using Olx.Attributes;
using Olx.Services;
using DriverService = Olx.Services.DriverService;

namespace Olx.Pages.MainPage
{
	[Url("https://www.olx.ua/")]
	public class MainPage : BasePage
	{
		private MainPageLayout layout;
		public MainPage()
		{
			this.layout = new MainPageLayout();
		}

		public override void Open()
		{
			var url = this.GetUrl();
			DriverService.Driver.Navigate().GoToUrl(url);
		}

		public void CreateClick()
		{
			DriverService.Wait.Until(drv => layout.NewAdBtn.Displayed);
			layout.NewAdBtn.Click();
		}

		public void Login()
		{
			var user = LoginService.GetDefaultUser();
			DriverService.Wait.Until(drv => layout.UserNameField.Displayed);
			layout.UserNameField.SendKeys(user.UserName);
			layout.PasswordField.SendKeys(user.Password);
			layout.LoginBtn.Click();
		}
	}
}