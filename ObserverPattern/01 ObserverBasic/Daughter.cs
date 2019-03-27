using System;

namespace _01_ObserverBasic
{
	public class Daughter : IObserver
	{
		public void Update(string item)
		{
			Console.WriteLine($"Daughter: {item.ToUpper()}! thank you!!!");
		}
	}
}
