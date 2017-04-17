using System;
using System.Net.Http;
using Newtonsoft.Json;

namespace Api
{
	public class WebService
	{
		private readonly HttpClient httpClient;

		private readonly string detailTemplate =
			"https://www.mybookingpal.com/xml/services/json/reservation/quotes?pos={position}&productid={productId}&fromdate={startDate}&todate={endDate}&currency=USD&adults=2";

		private readonly string searchTemplate =
			"https://www.mybookingpal.com/xml/services/json/reservation/products/21980/{startDate}/{endDate}?pos={position}&guests=2&amenity=true&currency=USD&exec_match=false&display_inquire_only=false";

		private string _startDate = "{startDate}";
		private string _endDate = "{endDate}";
		private string _position = "{position}";
		private string _dateFormat = "yyyy'-'MM'-'dd";
		private string _productId = "{productId}";

		public WebService()
		{
			httpClient = new HttpClient();
		}

		public TModel GetModel<TModel>(string request) where TModel : class
		{
			var response = httpClient.GetAsync(request).Result;
			var mes = response.Content.ReadAsStringAsync().Result;
			var ent = JsonConvert.DeserializeObject<TModel>(mes);
			return ent;
		}

		public string StartDate()
		{
			var today = DateTime.Now;
			var tomorrow = today.AddMonths(1);
			return tomorrow.ToString(_dateFormat);
		}

		public string EndDate()
		{
			var today = DateTime.Now;
			var oneWeekAfter = today.AddMonths(1).AddDays(7);
			return oneWeekAfter.ToString(_dateFormat);
		}

		public string GetSearchRequestString(string startDate, string endDate, string position)
		{
			var today = DateTime.Now;
			var tomorrow = today.AddDays(1);
			var oneWeekAfter = tomorrow.AddDays(7);
			var searchString = searchTemplate.Replace(_startDate, tomorrow.ToString(_dateFormat))
											 .Replace(_endDate, oneWeekAfter.ToString(_dateFormat))
											 .Replace(_position, position);

			return searchString;
		}

		public string GetDetailRequestString(string startDate, string endDate, string position, string productId)
		{
			var searchString = detailTemplate.Replace(_startDate, startDate)
											.Replace(_endDate, endDate)
											.Replace(_position, position)
											.Replace(_productId, productId);

			return searchString;
		}
	}
}