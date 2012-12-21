using System;

namespace Patterns.Behavioural.ObjectPipeline.Steps
{
	public class AllocateStockStep : OrderPipelineStep
	{
		public override SalesOrder HandleOrder(SalesOrder order)
		{
			if (!order.IsSoftwareProduct)
			{
				Console.WriteLine("Product {0} allocated in SOP system", order.ProductCode);
			}
			return GetOrderOrNextStepResult(order);
		}
	}
}
