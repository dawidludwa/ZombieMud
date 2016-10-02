using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Units
{
	abstract class Factory : IFactory
	{
		protected IStrategyFactory strategyFactory;

		public Factory(IStrategyFactory strategyFactory)
		{
			this.strategyFactory = strategyFactory;
		}
		public abstract IUnit Create();

		//{
		//	return new Unit(strategyFactory.Create(), 100);
		//}
	}
}
