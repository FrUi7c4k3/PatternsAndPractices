using System;

namespace Patterns.Behavioural.ObjectPipeline.Steps
{
	public class SendInvoiceStep : OrderPipelineStep
	{
		public override SalesOrder HandleOrder(SalesOrder order)
		{
			Console.WriteLine("Invoice sent to {0}", order.CustomerEmail);
			return GetOrderOrNextStepResult(order);
		}
	}
}