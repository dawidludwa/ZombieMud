using System;
using System.Collections.Generic;
using Library.Misc;
using System.Text;

namespace Library.Units
{
	public class Outfit : Item
	{
		internal static Outfit Empty()
		{
			return new Outfit("Empty", 0, 0, new List<Buff>(), 0, 0);
		}

		

		public Outfit(string Name, float Weight, float Size, List<Buff> buffs, float Attack, float Defense) : base(Name, Weight, Size, buffs)
		{
			this.Attack = Attack;
			this.Defense = Defense;
		}

		public float Attack { get; private set; }
		public float Defense { get; private set; }

		

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append(string.Format("Outfit: {0}, Weight {1}, Size {2}, Attack {3}, Defense {4}", Name, Weight, Size, Attack, Defense));
			foreach (var buff in buffs)
			{
				sb.Append(buff.ToString());
			}
			return sb.ToString();
		}
	}
}