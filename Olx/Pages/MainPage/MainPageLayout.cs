using OpenQA.Selenium;
using DriverService = Olx.Services.DriverService;

namespace Olx.Pages.MainPage
{
	public class MainPageLayout
	{
		public IWebElement NewAdBtn => DriverService.Driver.FindElement(By.Id("postNewAdLink"));
		public IWebElement UserNameField => DriverService.Driver.FindElement(By.XPath("//input[@id='userEmail']"));
		public IWebElement PasswordField => DriverService.Driver.FindElement(By.Name("login[password]"));
		public IWebElement LoginBtn => DriverService.Driver.FindElement(By.XPath("//*[@class='login-button' and @id='se_userLogin']"));
	}
}