namespace _02_ObserverDifferentNotification
{
	public interface ISubject
	{
		void Attach(IObserver observer);

		void Detach(IObserver observer);

		void AfterBuyingAnItem(string item);

		void AfterBuyingMoreItem(string completeItem, string newItem);
	}
}
