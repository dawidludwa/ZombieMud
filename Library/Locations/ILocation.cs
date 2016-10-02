namespace Library.Locations
{
	public interface ILocation
	{
		string Name { get; }

		void Add(ILocation location);
		ILocation GetLocation(string name);
		ILocation GetRandomLocation();
		void Remove(ILocation location);
	}
}