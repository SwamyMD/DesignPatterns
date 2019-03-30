using System;

namespace _03_ObserverAdvance
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
