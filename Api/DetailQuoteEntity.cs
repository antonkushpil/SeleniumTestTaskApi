using System.Collections.Generic;

namespace Api
{
	public class QuoteDetail
	{
		public int amount { get; set; }
		public string currency { get; set; }
		public string description { get; set; }
		public string entity { get; set; }
		public bool included { get; set; }
		public string paymentInfo { get; set; }
		public string text { get; set; }
		public string type { get; set; }
	}

	public class QuoteDetails
	{
		public List<QuoteDetail> quoteDetails { get; set; }
	}

	public class CancellationItem
	{
		public double cancellationAmount { get; set; }
		public string cancellationDate { get; set; }
		public int cancellationNights { get; set; }
		public double cancellationPercentage { get; set; }
		public int cancellationType { get; set; }
		public int daysBeforeArrival { get; set; }
		public double transactionFee { get; set; }
	}

	public class PropertyManagerSupportCC
	{
		public bool supportAE { get; set; }
		public bool supportDINERSCLUB { get; set; }
		public bool supportDISCOVER { get; set; }
		public bool supportJCB { get; set; }
		public bool supportMC { get; set; }
		public bool supportVISA { get; set; }
	}

	public class Quotes
	{
		public bool is_error { get; set; }
		public string message { get; set; }
		public string messageCode { get; set; }
		public string fromTime { get; set; }
		public string toTime { get; set; }
		public string currency { get; set; }
		public double quote { get; set; }
		public double price { get; set; }
		public string termsLink { get; set; }
		public int minstay { get; set; }
		public double firstPayment { get; set; }
		public double secondPayment { get; set; }
		public string propertyName { get; set; }
		public string imageUrl { get; set; }
		public double agentCommission { get; set; }
		public double agentCommissionValue { get; set; }
		public string secondPaymentDate { get; set; }
		public bool paymentSupported { get; set; }
		public QuoteDetails quote_details { get; set; }
		public List<CancellationItem> cancellationItems { get; set; }
		public PropertyManagerSupportCC propertyManagerSupportCC { get; set; }
		public bool available { get; set; }
		public double property_quote { get; set; }
		public string property_currency { get; set; }
	}

	public class DetailRootObject
	{
		public Quotes quotes { get; set; }
	}
}