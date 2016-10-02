using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Misc;

namespace Library.Units
{
	class ZombieUnit : IUnit
	{
		private IUnit unit;
		public ZombieUnit(IUnit unit)
		{
			this.unit = unit;
		}

		public bool IsAlive
		{
			get
			{
				return unit.IsAlive;
			}
		}

		public string Name
		{
			get
			{
				return "Zombie " + unit.Name;
			}
		}

		public void AcceptItem(Item item)
		{
			throw new NotImplementedException();
		}

		public void AddInfection(string v)
		{
			//unit.AddInfection(v);
		}

		public void Attack(IUnit unit)
		{
			this.unit.Attack(unit);
			unit.AddInfection("infection lvl. 1");
		}

		public void Defense(float attack)
		{
			if(attack - 5 > 0)
			{
				unit.Defense(attack - 5);
			}
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append(unit.ToString());
			
			return sb.Replace(unit.Name, Name).ToString();
		}
	}
}
