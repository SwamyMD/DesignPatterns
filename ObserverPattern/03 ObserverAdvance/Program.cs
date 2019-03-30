using System;

namespace _03_ObserverAdvance
{
	class Program
	{
		static void Main(string[] args)
		{

			Dad dad = new Dad();
			Son son = new Son();
			Daughter daughter = new Daughter();


			dad.AfterBuyingAnItem = new MulticastNotifier<string>(new[]
			{
				daughter.AfterBuyingAnItem,
				son.AfterBuyingAnItem
			});

			dad.AfterBuyingMoreItem = new MulticastNotifier<Tuple<string, string>>(new[]
			{
				daughter.AfterBuyingMoreItem
			});

			dad.BuyItem("pizza");
			Console.WriteLine();
			dad.BuyMoreItem("chocolates");

			Console.ReadLine();
		}
	}
}
