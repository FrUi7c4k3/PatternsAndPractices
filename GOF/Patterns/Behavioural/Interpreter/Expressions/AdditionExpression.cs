namespace Patterns.Behavioural.Interpreter.Expressions
{
	public class AdditionExpression : ExpressionBase
	{
		private ExpressionBase _expression1;
		private ExpressionBase _expression2;
		
		public AdditionExpression(ExpressionBase exp1, ExpressionBase exp2)
		{
			_expression1 = exp1;
			_expression2 = exp2;
		}

		public override int Evaluate()
		{
			int value1 = _expression1.Evaluate();
			int value2 = _expression2.Evaluate();

			return value1 + value2;
		}

		public override string ToString()
		{
			return string.Format("({0} + {1})", _expression1, _expression2);
		}
	}
}
