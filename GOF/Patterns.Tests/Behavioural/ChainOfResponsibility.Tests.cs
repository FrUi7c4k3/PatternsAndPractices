using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patterns.Behavioural.ChainOfResponsibility;
using Patterns.Behavioural.ChainOfResponsibility.Handlers;

namespace Patterns.Tests.Behavioural
{
	[TestClass]
	public class ChainOfResponsibilityTests
	{
		/// <summary>
		/// A design pattern that defines a linked list of handlers, 
		/// each of which is able to process requests. 
		/// When a request is submitted to the chain, 
		/// it is passed to the first handler in the list that is able to process it.
		/// </summary>
		[TestMethod]
		public void TestMethod1()
		{
			CoinHandlerBase h5 = new FivePenceHandler();
			CoinHandlerBase h10 = new TenPenceHandler();
			CoinHandlerBase h20 = new TwentyPenceHandler();
			CoinHandlerBase h50 = new FiftyPenceHandler();
			CoinHandlerBase h100 = new OnePoundHandler();
			h5.SetSuccessor(h10);
			h10.SetSuccessor(h20);
			h20.SetSuccessor(h50);
			h50.SetSuccessor(h100);

			Coin tenPence = new Coin { Diameter = 24.49F, Weight = 6.5F };
			Coin fiftyPence = new Coin { Diameter = 27.31F, Weight = 8.01F };
			Coin counterfeitPound = new Coin { Diameter = 22.5F, Weight = 9F };

			h5.HandleCoin(tenPence);
			h5.HandleCoin(fiftyPence);
			h5.HandleCoin(counterfeitPound);
		}
	}
}
