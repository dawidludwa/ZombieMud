using Library.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Misc
{
	public abstract class Item 
	{
		protected readonly List<Buff> buffs = new List<Buff>();

		public Item(string Name, float Weight, float Size, List<Buff> buffs)
		{
			this.Name = Name;
			this.Weight = Weight;
			this.Size = Size;
			this.buffs.AddRange(buffs);
		}

		public string Name { get; private set; }
		public float Weight { get; private set; }
		public float Size { get; private set; }

		public void VisitUnit(ICanWearItem unit)
		{
			unit.AddItem(this);
			foreach (var buff in buffs)
			{
				unit.AddBuff(buff);
			}
			//unit.AddBuff()
			//unit.AcceptItem(this);

		}
	}
}
