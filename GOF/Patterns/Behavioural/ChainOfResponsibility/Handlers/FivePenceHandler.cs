using System;
using System.Diagnostics;

namespace Patterns.Behavioural.ChainOfResponsibility.Handlers
{
	public class FivePenceHandler : CoinHandlerBase
	{
		public override void HandleCoin(Coin coin)
		{
			if (Math.Abs(coin.Weight - 3.25) < 0.02 && Math.Abs(coin.Diameter - 18) < 0.1)
				Debug.WriteLine("Captured 5p");
			else if (_successor != null)
				_successor.HandleCoin(coin);
		}
	}
}
