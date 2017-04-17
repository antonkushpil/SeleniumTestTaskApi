using System;
using System.Linq;
using NUnit.Framework;

namespace Api
{
	[TestFixture]
	[Category("Ready")]
	[Category("Api")]
	public class Tests
	{
		[Test, Description("Test that quote price on search and detail pages is the same")]
		public void CheckQuote()
		{
			var service = new WebService();

			//Don't see such apartment, also changed dates
			//var expectedApartment = "Apartment Bouchardon";

			var expectedApartment = "Paris Holiday Apartment BL19679669925.";
			var parisPos = "a502d2c65c2f75d3";
			var startDate = service.StartDate();
			var endDate = service.EndDate();

			var searchRequest = service.GetSearchRequestString(startDate, endDate, parisPos);
			var search = service.GetModel<SearchResponseRootObject>(searchRequest);

			var quotes = search.search_response.search_quotes.quote;
			if (quotes.Count == 0)
				throw new Exception("No quotes found");

			var expectedQuote = new Quote();
			if (quotes.Any(q => q.productname == expectedApartment))
			{
				expectedQuote = quotes.First(q => q.productname == expectedApartment);
			}
			else
			{
				throw new Exception(String.Format("No such apartment found: {}, please choose another one", expectedApartment));
			}

			var detailRequest = service.GetDetailRequestString(startDate, endDate, parisPos, expectedQuote.productid.ToString());
			var detailEntity = service.GetModel<DetailRootObject>(detailRequest);
			var expectedQuotePrice = expectedQuote.quote;
			var actualQuotePrice = detailEntity.quotes.quote;
			var delta = expectedQuotePrice * 0.01;

			Assert.AreEqual(expectedQuotePrice, actualQuotePrice, delta, "Price and qoute are not equal");
		}
	}
}
