using System;

namespace _02_ObserverDifferentNotification
{
	class Program
	{
		static void Main(string[] args)
		{
			Dad dad = new Dad();
			dad.Attach(new Daughter());
			dad.Attach(new Son());

			dad.BuyItem("pizza");
			Console.WriteLine();
			dad.BuyMoreItem("chocolates");

			Console.ReadLine();
		}
	}
}
