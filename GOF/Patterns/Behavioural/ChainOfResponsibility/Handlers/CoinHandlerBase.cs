namespace Patterns.Behavioural.ChainOfResponsibility.Handlers
{
	public abstract class CoinHandlerBase
	{
		protected CoinHandlerBase _successor;

		public abstract void HandleCoin(Coin coin);

		public void SetSuccessor(CoinHandlerBase successor)
		{
			_successor = successor;
		}
	}
}
