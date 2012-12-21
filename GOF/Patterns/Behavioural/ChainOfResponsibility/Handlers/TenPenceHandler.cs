using System;
using System.Diagnostics;

namespace Patterns.Behavioural.ChainOfResponsibility.Handlers
{
	public class TenPenceHandler : CoinHandlerBase
	{
		public override void HandleCoin(Coin coin)
		{
			if (Math.Abs(coin.Weight - 6.5) < 0.03 && Math.Abs(coin.Diameter - 24.5) < 0.15)
				Debug.WriteLine("Captured 10p");
			else if (_successor != null)
				_successor.HandleCoin(coin);
		}
	}
}
