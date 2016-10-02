using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Locations
{
	class LocationLogger : ILocation
	{
		private ILogger logger;
		private ILocation location;

		public LocationLogger(ILocation location, ILogger logger)
		{
			this.logger = logger;
			this.location = location;
			logger.WriteLine("Create location: " + location.Name);
		}

		public string Name
		{
			get
			{
				return location.Name;
			}
		}

		public void Add(ILocation location)
		{
			try
			{
				this.location.Add(location);
				logger.WriteLine("location: " + location.Name + " added to " + this.location.Name);
			}
			catch (Exception e)
			{
				logger.WriteLine(e.Message);
			}
		}

		public ILocation GetLocation(string name)
		{
			ILocation ret = null;
			try
			{
				ret = this.location.GetLocation(name);
				logger.WriteLine("from location: " + location.Name + " get " + this.location.Name);
			}
			catch (Exception e)
			{
				logger.WriteLine(e.Message);
			}

			return ret;
		}

		public ILocation GetRandomLocation()
		{
			var loc = this.location.GetRandomLocation();
			logger.WriteLine("get random loation: " + loc.Name);

			return loc;
		}

		public void Remove(ILocation location)
		{
			try
			{
				this.location.Remove(location);
				logger.WriteLine("location: " + location.Name + " removed from " + this.location.Name);
			}
			catch (Exception e)
			{
				logger.WriteLine(e.Message);
			}
		}
	}
}
