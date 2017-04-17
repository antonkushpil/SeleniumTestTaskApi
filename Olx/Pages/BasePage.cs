using System.Reflection;
using Olx.Attributes;
using Olx.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using DriverService = Olx.Services.DriverService;

namespace Olx.Pages
{
	public abstract class BasePage : IPage
	{
		public abstract void Open();

		public virtual string GetUrl()
		{
			return this.GetType().GetCustomAttribute<UrlAttribute>().GetUrl();
		}

		public virtual void SelectDropDown(IWebElement element, string option)
		{
			element.Click();
			var xpath = string.Format("//a[contains(text(),'{0}')] ", option);
			DriverService.Driver.FindElement(By.XPath(xpath)).Click();
		}

		public virtual void ClickWithScroll(IWebElement element)
		{
			Actions actions = new Actions(DriverService.Driver);
			actions.MoveToElement(element);
			actions.Perform();
			element.Click();
		}
	}
}