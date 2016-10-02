using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Units
{
	class ZombieFactory : IFactory
	{
		private IFactory unitFactory;
		public ZombieFactory(IFactory unitFactory)
		{
			this.unitFactory = unitFactory;
		}

		public IUnit Create()
		{
			return new ZombieUnit(unitFactory.Create());
		}
	}
}
