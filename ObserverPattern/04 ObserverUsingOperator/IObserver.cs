namespace _04_ObserverUsingOperator
{
	public interface IObserver<T>
	{
		void Update(T item);
	}
}
