using OpenQA.Selenium;
using DriverService = Olx.Services.DriverService;

namespace Olx.Pages.NewAdPage
{
	public class NewAdPageLayout
	{
		public IWebElement Title => DriverService.Driver.FindElement(By.Id("add-title"));
		public IWebElement TargetTrenderBtn => DriverService.Driver.FindElement(By.Id("targetrenderSelect1-0"));
		public IWebElement TargetTrenderChooseBtn => DriverService.Driver.FindElement(By.Id("cat-44"));
		public IWebElement ModelDropDown => DriverService.Driver.FindElement(By.Id("targetparam113"));
		public IWebElement OSDropDown => DriverService.Driver.FindElement(By.Id("targetparam426"));
		public IWebElement DisplayDropDown => DriverService.Driver.FindElement(By.Id("targetparam428"));
		public IWebElement Price => DriverService.Driver.FindElement(By.Name("data[param_price][1]"));
		public IWebElement ConditionDropDown => DriverService.Driver.FindElement(By.Id("targetparam13"));
		public IWebElement BusinessDropDown => DriverService.Driver.FindElement(By.Id("targetid_private_business"));
		public IWebElement Description => DriverService.Driver.FindElement(By.Id("add-description"));
		public IWebElement PreviewBtn => DriverService.Driver.FindElement(By.Id("preview-link"));
		public IWebElement CookiesBannerCloseBtn => DriverService.Driver.FindElement(By.CssSelector("[data-icon='close']"));

	}
}