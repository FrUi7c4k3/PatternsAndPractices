using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patterns.Behavioural.Interpreter;
using Patterns.Behavioural.Interpreter.Expressions;

namespace Patterns.Tests.Behavioural
{
	[TestClass]
	public class InterpreterTests
	{
		/// <summary>
		/// The interpreter pattern is a design pattern that is useful when developing domain-specific 
		/// languages or notations. The pattern allows the grammar for such a notation to be represented 
		/// in an object-oriented fashion that can easily be extended. - check polish notation for grammer rules
		/// </summary>
		[TestMethod]
		public void TestMethod1()
		{
			Parser parser = new Parser();

			string[] commands = new string[]
			{
			    "+ 5 6",
			    "- 6 5",
			    "+ - 4 5 6",
			    "+ 4 - 5 6",
			    "+ - + - - 2 3 4 + - -5 6 + -7 8 9 10"
			};

			foreach (string command in commands)
			{
				ExpressionBase expression = parser.Parse(command);
				Console.WriteLine("{0} = {1}", expression, expression.Evaluate());
			}
		}
	}
}
