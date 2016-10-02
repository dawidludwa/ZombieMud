using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Misc;

namespace Library.Units
{
	class ArmedUnit : IUnit
	{
		private readonly IUnit unit;
		private readonly Outfit armorSet;
		public ArmedUnit(IUnit unit, Outfit armorSet)
		{
			this.unit = unit;
			this.armorSet = armorSet;
		}

		public bool IsAlive
		{
			get
			{
				return this.unit.IsAlive;
			}
		}

		public string Name
		{
			get
			{
				return this.unit.Name;
			}
		}

		public void AcceptItem(Item item)
		{
			this.unit.AcceptItem(item);
		}

		public void AddInfection(string v)
		{
			this.unit.AddInfection(v);
		}

		public void Attack(IUnit unit)
		{
			this.unit.Attack(unit);

		}

		public void Defense(float attack)
		{
			this.unit.Defense(attack);
		}
	}
}
