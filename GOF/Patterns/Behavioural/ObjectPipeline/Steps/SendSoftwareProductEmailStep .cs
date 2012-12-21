using System;

namespace Patterns.Behavioural.ObjectPipeline.Steps
{
	public class SendSoftwareProductEmailStep : OrderPipelineStep
	{
		public override SalesOrder HandleOrder(SalesOrder order)
		{
			if (order.IsSoftwareProduct)
			{
				Console.WriteLine("Download link sent to {0}", order.CustomerEmail);
			}
			return GetOrderOrNextStepResult(order);
		}
	}
}
