using System;

namespace _02_ObserverDifferentNotification
{
	public class Daughter : IObserver
	{
		void IObserver.AfterBuyingAnItem(string item)
		{
			Console.WriteLine($"Daughter: {item.ToUpper()}! thank you!!!");
		}

		void IObserver.AfterBuyingMoreItem(string completeItem, string newItem)
		{
			Console.WriteLine($"Daughter: {newItem.ToUpper()}! thank you once again!");
		}
	}
}
