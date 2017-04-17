using System;
using Olx.Enums;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace Olx.Services
{
	public class DriverService
	{
		private static IWebDriver driver { get; set; }
		private static Browser browser { get; set; }
		public static IWebDriver Driver
		{
			get
			{
				if (driver == null)
				{
					if (browser == Browser.Firefox)
					{
						driver = new FirefoxDriver();

					}
					else
					{
						driver = InitChromeDriver();
					}
				}
				return driver;
			}
		}

		public static WebDriverWait Wait => new WebDriverWait(driver, TimeSpan.FromSeconds(5));

		internal static ChromeDriver InitChromeDriver()
		{
			var path = AppDomain.CurrentDomain.BaseDirectory;
			string webDriverPath = path + "\\Services\\Drivers";
			ChromeOptions options = new ChromeOptions();
			options.AddArgument("--disable-web-security");
			options.AddArgument("--incognito");
			options.AddArgument("--disable-extensions");
			options.AddArgument("--start-maximized");
			options.AddArgument("--ignore-certificate-errors");
			options.AddArgument("no-sandbox");
			ChromeDriver chromeDriver = new ChromeDriver(webDriverPath, options);

			return chromeDriver;
		}
	}
}