using System;

namespace _04_ObserverUsingOperator
{
	public class Dad
	{
		private string _items;
		public MulticastNotifier<string> AfterBuyingAnItem;
		public MulticastNotifier<Tuple<string, string>> AfterBuyingMoreItem;

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
				AfterBuyingAnItem.Notify(item);
		}

		private void OnAfterBuyingMoreItem(string completeItem, string newItem)
		{
			if (AfterBuyingMoreItem != null)
				AfterBuyingMoreItem.Notify(Tuple.Create(completeItem, newItem));
		}
	}
}
