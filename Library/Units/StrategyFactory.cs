using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Units
{
	class StrategyFactory : IStrategyFactory
	{
		public IStrategy Create()
		{
			return new Strategy(2);
		}
	}
}
