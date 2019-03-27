namespace _02_ObserverDifferentNotification
{
	public interface IObserver
	{
		void AfterBuyingAnItem(string item);

		void AfterBuyingMoreItem(string completeItem, string newItem);
	}
}
