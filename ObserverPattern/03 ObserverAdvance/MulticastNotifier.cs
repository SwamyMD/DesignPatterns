using System.Collections.Generic;

namespace _03_ObserverAdvance
{
	public class MulticastNotifier<T>
	{
		private readonly IList<IObserver<T>> _observers;

		public MulticastNotifier(IEnumerable<IObserver<T>> observers)
		{
			_observers = new List<IObserver<T>>(observers);
		}

		public void Notify(T item)
		{
			foreach (var observer in _observers)
			{
				observer.Update(item);
			}
		}
	}
}
