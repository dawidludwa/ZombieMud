using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Units
{
	class Strategy : IStrategy
	{
		private float defense;
		public Strategy(float defense)
		{
			this.defense = defense;
		}

		public float OnHit(float attack)
		{
			if (attack - defense > 0)
				return attack - defense;

			return 0;
		}
	}
}
