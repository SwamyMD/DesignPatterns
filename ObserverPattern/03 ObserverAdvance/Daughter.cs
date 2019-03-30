using System;

namespace _03_ObserverAdvance
{
	public class Daughter
	{
		public IObserver<string> AfterBuyingAnItem;
		public IObserver<Tuple<string, string>> AfterBuyingMoreItem;

		public Daughter()
		{
			AfterBuyingAnItem = new NotificationSink<string>(this.AfterBuyingAnItemHandler);
			AfterBuyingMoreItem = new NotificationSink<Tuple<string, string>>(this.AfterBuyingMoreItemHandler);
		}
		private void AfterBuyingAnItemHandler(string item)
		{
			Console.WriteLine($"Daughter: {item.ToUpper()}! thank you!!!");
		}

		private void AfterBuyingMoreItemHandler(Tuple<string, string> items)
		{
			Console.WriteLine($"Daughter: {items.Item2.ToUpper()}! thank you once again!");
		}
	}
}
