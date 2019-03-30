using System;

namespace _05_ObserverUsingEvents
{
	public class Dad
	{
		private string _items;
		public event EventHandler<string> AfterBuyingAnItem;
		public event EventHandler<Tuple<string, string>> AfterBuyingMoreItem;

		public void BuyItem(string item)
		{
			_items = item;
			Console.WriteLine($"Dad: guys {item}");
			OnAfterBuyingAnItem(item);
		}

		public void BuyMoreItem(string newitem)
		{
			_items += newitem;
			Console.WriteLine($"Dad: guys {newitem}");
			OnAfterBuyingMoreItem(_items, newitem);
		}


		private void OnAfterBuyingAnItem(string item)
		{
			if (AfterBuyingAnItem != null)
				AfterBuyingAnItem(this, item);
		}

		private void OnAfterBuyingMoreItem(string completeItem, string newItem)
		{
			if (AfterBuyingMoreItem != null)
				AfterBuyingMoreItem(this, Tuple.Create(completeItem, newItem));
		}
	}
}
