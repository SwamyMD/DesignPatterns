using System.Collections.Generic;

namespace _04_ObserverUsingOperator
{
	public class MulticastNotifier<T>
	{
		private IList<IObserver<T>> _observers;

		private MulticastNotifier(IObserver<T> observer)
		{
			_observers = new List<IObserver<T>>();
			_observers.Add(observer);
		}

		private MulticastNotifier(MulticastNotifier<T> notifier, IObserver<T> observer)
		{
			_observers = new List<IObserver<T>>(notifier._observers);
			_observers.Add(observer);
		}

		public void Notify(T item)
		{
			foreach (var observer in _observers)
			{
				observer.Update(item);
			}
		}

		public static MulticastNotifier<T> operator +(MulticastNotifier<T> notifier, IObserver<T> observer)
		{
			if (notifier == null)
				return new MulticastNotifier<T>(observer);

			return new MulticastNotifier<T>(notifier, observer);
		}
	}
}
