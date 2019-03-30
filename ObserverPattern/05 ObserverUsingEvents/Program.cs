using System;

namespace _05_ObserverUsingEvents
{
	class Program
	{
		static void Main(string[] args)
		{
			Dad dad = new Dad();
			Son son = new Son();
			Daughter daughter = new Daughter();

			dad.AfterBuyingAnItem += son.AfterBuyingAnItem;
			dad.AfterBuyingAnItem += daughter.AfterBuyingAnItem;

			dad.AfterBuyingMoreItem += daughter.AfterBuyingMoreItem;

			dad.BuyItem("pizza");
			Console.WriteLine();
			dad.BuyMoreItem("chocolates");

			Console.ReadLine();
		}
	}
}
