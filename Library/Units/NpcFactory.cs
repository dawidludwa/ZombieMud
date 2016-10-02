using Library.Locations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Units
{
	public class NpcFactory
	{
		private IStrategyFactory strategyFactory;
		private IFactory zombieFactory;
		private IFactory unitFactory;
		public NpcFactory()
		{
			strategyFactory = new StrategyFactory();
			unitFactory = new UnitFactory(strategyFactory);
			zombieFactory = new ZombieFactory(unitFactory);
		}

		public IUnit CreateZombieUnit()
		{
			return new LoggerUnit(zombieFactory.Create(), new AjneMajneLogger());
		}
		public IUnit CreateUnit()
		{
			return new LoggerUnit(unitFactory.Create(), new AjneMajneLogger());
		}
	}
}
