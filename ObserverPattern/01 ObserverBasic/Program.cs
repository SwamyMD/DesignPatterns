using System;

namespace _01_ObserverBasic
{
	class Program
	{
		static void Main(string[] args)
		{
			Dad dad = new Dad();
			dad.Attach(new Daughter());
			dad.Attach(new Son());

			dad.BuyItem("chocolates");

			Console.ReadLine();
		}
	}
}
