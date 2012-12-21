using System;
using System.Diagnostics;

namespace Patterns.Behavioural.ChainOfResponsibility.Handlers
{
	public class TwentyPenceHandler : CoinHandlerBase
	{
		public override void HandleCoin(Coin coin)
		{
			if (Math.Abs(coin.Weight - 5) < 0.01 && Math.Abs(coin.Diameter - 21.4) < 0.1)
				Debug.WriteLine("Captured 20p");
			else if (_successor != null)
				_successor.HandleCoin(coin);
		}
	}
}
