namespace Patterns.Behavioural.ObjectPipeline
{
	public class SalesOrder
	{
		public string ProductCode { get; set; }
		public bool IsSoftwareProduct { get; set; }
		public string CustomerEmail { get; set; }
		public string OrderNumber { get; set; }
	}
}
