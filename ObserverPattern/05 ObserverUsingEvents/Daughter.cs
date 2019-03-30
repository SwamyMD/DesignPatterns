using System;

namespace _05_ObserverUsingEvents
{
	public class Daughter
	{
		public void AfterBuyingAnItem(object sender, string item)
		{
			Console.WriteLine($"Daughter: {item.ToUpper()}! thank you!!!");
		}

		public void AfterBuyingMoreItem(object sender, Tuple<string, string> items)
		{
			Console.WriteLine($"Daughter: {items.Item2.ToUpper()}! thank you once again!");
		}
	}
}
