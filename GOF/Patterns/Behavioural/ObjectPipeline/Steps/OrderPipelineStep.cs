namespace Patterns.Behavioural.ObjectPipeline.Steps
{
	public abstract class OrderPipelineStep
	{
		protected OrderPipelineStep _nextStep;

		/// <summary>
		/// Unlike the Chain of Responsibility pattern, 
		/// each step returns a Salesorder as an input 
		/// into the next step in the pipeline.
		/// </summary>
		/// <param name="salesOrder"></param>
		/// <returns>The processed SalesOrder to be fed as input into the next step.</returns>
		public abstract SalesOrder HandleOrder(SalesOrder salesOrder);

		public void SetNextStep(OrderPipelineStep nextStep)
		{
			_nextStep = nextStep;
		}

		protected SalesOrder GetOrderOrNextStepResult(SalesOrder salesOrder)
		{
			return _nextStep == null ? salesOrder : _nextStep.HandleOrder(salesOrder);
		}
	}
}
