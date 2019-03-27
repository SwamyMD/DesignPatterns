using System;
using System.Collections.Generic;

namespace _02_ObserverDifferentNotification
{
	public class Dad : ISubject
	{
		private readonly List<IObserver> _observers;
		private string _items;

		public Dad()
		{
			_observers = new List<IObserver>();
		}

		public void BuyItem(string item)
		{
			_items = item;
			Console.WriteLine($"Dad: guys {item}");
			AfterBuyingAnItem(item);
		}

		public void BuyMoreItem(string newitem)
		{
			_items += newitem;
			Console.WriteLine($"Dad: guys {newitem}");
			AfterBuyingMoreItem(_items, newitem);
		}

		public void Attach(IObserver observer)
		{
			_observers.Add(observer);
		}

		public void Detach(IObserver observer)
		{
			_observers.Remove(observer);
		}

		public void AfterBuyingAnItem(string item)
		{
			foreach (var observer in _observers)
			{
				observer.AfterBuyingAnItem(item);
			}
		}

		public void AfterBuyingMoreItem(string completeItem, string newItem)
		{
			foreach (var observer in _observers)
			{
				observer.AfterBuyingMoreItem(completeItem, newItem);
			}
		}
	}
}
