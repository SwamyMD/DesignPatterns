using System;

namespace _04_ObserverUsingOperator
{
	public class Son
	{
		public IObserver<string> AfterBuyingAnItem;

		public Son()
		{
			AfterBuyingAnItem = new NotificationSink<string>(this.AfterBuyingAnItemHandler);
		}
		public void AfterBuyingAnItemHandler(string item)
		{
			Console.WriteLine($"Son: {item.ToUpper()}, coming...");
		}
	}
}
