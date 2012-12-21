using System;
using System.Diagnostics;

namespace Patterns.Behavioural.ChainOfResponsibility.Handlers
{
	public class FiftyPenceHandler : CoinHandlerBase
	{
		public override void HandleCoin(Coin coin)
		{
			if (Math.Abs(coin.Weight - 8) < 0.02 && Math.Abs(coin.Diameter - 27.3) < 0.15)
				Debug.WriteLine("Captured 50p");
			else if (_successor != null)
				_successor.HandleCoin(coin);
		}
	}
}
