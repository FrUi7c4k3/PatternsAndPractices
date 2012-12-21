using System;
using System.Diagnostics;

namespace Patterns.Behavioural.ChainOfResponsibility.Handlers
{
	public class OnePoundHandler : CoinHandlerBase
	{
		public override void HandleCoin(Coin coin)
		{
			if (Math.Abs(coin.Weight - 9.5) < 0.02 && Math.Abs(coin.Diameter - 22.5) < 0.13)
				Debug.WriteLine("Captured £1");
			else if (_successor != null)
				_successor.HandleCoin(coin);
		}
	}
}
