using System;

namespace _04_ObserverUsingOperator
{
	public class NotificationSink<T> : IObserver<T>
	{
		private Action<T> _action;

		public NotificationSink(Action<T> action)
		{
			_action = action;
		}

		public void Update(T item)
		{
			_action(item);
		}
	}
}
