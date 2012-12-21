using System;

namespace Patterns.Behavioural.ObjectPipeline.Steps
{
	public class StoreOrderStep : OrderPipelineStep
	{
		public override SalesOrder HandleOrder(SalesOrder salesOrder)
		{
			salesOrder.OrderNumber = DateTime.Now.ToString("yyyyMMddHHmmss");
			Console.WriteLine("Order #{0} stored in SOP system", salesOrder.OrderNumber);

			return GetOrderOrNextStepResult(salesOrder);
		}
	}
}
