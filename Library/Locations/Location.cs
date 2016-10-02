using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Locations
{
	class Location : ILocation
	{
		private static Random rand = new Random();
		private readonly List<ILocation> locations = new List<ILocation>();

		public string Name { get; internal set; }

		public Location(string name)
		{
			this.Name = name;
		}

		public void Add(ILocation location)
		{
			if (locations.Contains(location))
				throw new LocationAlreadyExistsException(host: this, guest: location);

			locations.Add(location);
		}

		public void Remove(ILocation location)
		{
			if (!locations.Contains(location))
				throw new LocationNotExistsException(host: this, guest: location);

			locations.Remove(location);
		}

		public ILocation GetRandomLocation()
		{
			return locations[rand.Next(locations.Count)];
		}

		public ILocation GetLocation(string name)
		{
			var loc = locations.Find(lo => lo.Name == name);
			if (loc == null)
				throw new LocationNotExistsException(host: this, guest: name);

			return loc;
		}
	}
}
