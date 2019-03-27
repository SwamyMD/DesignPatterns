using System;
using System.Collections.Generic;

namespace _01_ObserverBasic
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
			Notify(item);
		}

		public void Attach(IObserver observer)
		{
			_observers.Add(observer);
		}

		public void Detach(IObserver observer)
		{
			_observers.Remove(observer);
		}

		public void Notify(string item)
		{
			foreach (var observer in _observers)
			{
				observer.Update(item);
			}
		}
	}
}
