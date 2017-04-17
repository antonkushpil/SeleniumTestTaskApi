using NUnit.Framework;
using Olx.Pages.MainPage;
using Olx.Pages.NewAdPage;
using Olx.Services;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using DriverService = Olx.Services.DriverService;

namespace Olx.Steps
{
	[Binding]
	public sealed class NewAdSteps
	{
		private FeatureContext context;
		public NewAdSteps(FeatureContext context)
		{
			this.context = context;
		}

		[Given(@"Main page is opened")]
		public void GivenMainPageIsOpened()
		{
			PageService.Create<MainPage>().Open();
		}

		[Given(@"(.*) button is clicked")]
		[When(@"(.*) button is clicked")]
		public void GivenButtonIsClicked(string buttonName)
		{
			if (buttonName == "NewAd")
			{
				PageService.Create<MainPage>().CreateClick();
			}
			else if (buttonName == "Preview")
			{
				PageService.Create<NewAdPage>().PreviewClick();
			}
		}

		[Given(@"I am logged in")]
		public void GivenIAmLoggedIn()
		{
			PageService.Create<MainPage>().Login();
		}

		[Given(@"Form is filled")]
		public void GivenFormIsFilled()
		{
			var title = "iphone 6s";
			PageService.Create<NewAdPage>().FillForm(title);
			context.Set(title, "title");
		}

		[Then(@"My Ad is shown")]
		public void ThenMyAdIsShown()
		{
			Assert.True(DriverService.Driver.FindElement(By.CssSelector("div[class*='previewcontent'")).Displayed);
		}

		[AfterScenario()]
		private void CloseDriver()
		{
			DriverService.Driver.Quit();
		}

	}
}
