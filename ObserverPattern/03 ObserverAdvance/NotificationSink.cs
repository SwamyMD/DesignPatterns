using System;

namespace _03_ObserverAdvance
{
	public class NotificationSink<T> : IObserver<T>
	{
		private readonly Action<T> _action;

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
