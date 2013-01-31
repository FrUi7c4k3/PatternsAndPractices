using System.Globalization;

namespace Patterns.Behavioural.Interpreter.Expressions
{
	public class IntegerExpression : ExpressionBase
	{
		private readonly int _value;

		public IntegerExpression(int value)
		{
			_value = value;
		}

		public override int Evaluate()
		{
			return _value;
		}

		public override string ToString()
		{
			return _value.ToString(CultureInfo.InvariantCulture);
		}
	}
}
