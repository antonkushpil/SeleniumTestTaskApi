using System;

namespace Olx.Attributes
{
	public class UrlAttribute : Attribute
	{
		private string url;

		public UrlAttribute(string url)
		{
			if (url == string.Empty)
				throw new Exception("Url is not specified!");
			this.url = url;
		}

		public string GetUrl()
		{
			return url;
		}
	}
}