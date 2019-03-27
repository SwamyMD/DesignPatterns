using System;

namespace _01_ObserverBasic
{
	public class Son : IObserver
	{
		public void Update(string item)
		{
			Console.WriteLine($"Son: {item.ToUpper()}, coming...");
		}
	}
}
