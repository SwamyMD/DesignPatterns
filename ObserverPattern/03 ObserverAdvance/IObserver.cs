namespace _03_ObserverAdvance
{
	public interface IObserver<in T>
	{
		void Update(T item);
	}
}
