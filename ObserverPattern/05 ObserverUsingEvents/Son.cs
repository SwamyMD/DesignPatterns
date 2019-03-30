using System;

namespace _05_ObserverUsingEvents
{
	public class Son
	{
		public void AfterBuyingAnItem(object sender, string item)
		{
			Console.WriteLine($"Son: {item.ToUpper()}, coming...");
		}
	}
}
