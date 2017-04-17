using System.Threading;
using Olx.Attributes;
using Olx.Services;

namespace Olx.Pages.NewAdPage
{
	[Url("https://www.olx.ua/post-new-ad")]
	public class NewAdPage : BasePage
	{
		private NewAdPageLayout layout;
		public NewAdPage()
		{
			layout = new NewAdPageLayout();
		}
		public override void Open()
		{
			throw new System.NotImplementedException();
		}
		public void FillForm(string title)
		{
			var descr = "Едва начав пользоваться iPhone 6s, вы сразу почувствуете, насколько всё изменилось. Технология 3D Touch открывает потрясающие новые возможности — достаточно одного нажатия. А функция Live Photos позволяет буквально оживить ваши воспоминания. И это только начало. Присмотритесь к iPhone 6s внимательнее, и вы увидите инновации на всех уровнях.";

			DriverService.Wait.Until(drv => layout.Title.Displayed);
			layout.Title.SendKeys(title);

			layout.TargetTrenderBtn.Click();
			ClickTrenderOnPopup();

			SelectDropDown(layout.ModelDropDown, "Apple");
			SelectDropDown(layout.OSDropDown, "iOS");
			SelectDropDown(layout.DisplayDropDown, "4.1");
			layout.Price.SendKeys("1000");
			SelectDropDown(layout.ConditionDropDown, "Б/у");
			SelectDropDown(layout.BusinessDropDown, "Частное лицо");
			layout.Description.SendKeys(descr);
		}

		public void PreviewClick()
		{
			layout.CookiesBannerCloseBtn.Click();
			ClickWithScroll(layout.PreviewBtn);
		}

		public void ClickTrenderOnPopup()
		{
			//Bad solution, I know, no time to find mandatory element for wait
			Thread.Sleep(1000);
			DriverService.Driver.SwitchTo().ActiveElement();
			layout.TargetTrenderChooseBtn.Click();
			Thread.Sleep(1000);
			DriverService.Driver.SwitchTo().ActiveElement();
		}

	}
}