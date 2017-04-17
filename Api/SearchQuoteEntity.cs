﻿using System.Collections.Generic;

namespace Api
{
	public class Quote
	{
		public string pictureLocation { get; set; }
		public int guests { get; set; }
		public int bedroom { get; set; }
		public int bathroom { get; set; }
		public int minstay { get; set; }
		public string productClassType { get; set; }
		public string managerName { get; set; }
		public bool inquiryOnly { get; set; }
		public string CheckInDayRequired { get; set; }
		public double rack { get; set; }
		public double quote { get; set; }
		public string address { get; set; }
		public bool exactmatch { get; set; }
		public List<object> suggestedby { get; set; }
		public List<string> attributes { get; set; }
		public int productid { get; set; }
		public string productname { get; set; }
	}

	public class SearchQuotes
	{
		public List<Quote> quote { get; set; }
	}

	public class SearchResponse
	{
		public string messageCode { get; set; }
		public string message { get; set; }
		public bool is_error { get; set; }
		public SearchQuotes search_quotes { get; set; }
	}

	public class SearchResponseRootObject
	{
		public SearchResponse search_response { get; set; }
	}
}