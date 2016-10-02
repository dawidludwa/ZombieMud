using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Locations
{
	public class LocationFactory
	{
		public ILocation Create(string name)
		{
			return new LocationLogger(new Location(name), new AjneMajneLogger());
		}
	}
}
