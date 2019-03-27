using System;

namespace _02_ObserverDifferentNotification
{
	public class Son : IObserver
	{

		public void AfterBuyingAnItem(string item)
		{
			Console.WriteLine($"Son: {item.ToUpper()}, coming...");
		}

		public void AfterBuyingMoreItem(string completeItem, string newItem)
		{
			Console.WriteLine($"Son: {newItem.ToUpper()}, Not interested! Why are you forcing me?");
		}
	}
}
