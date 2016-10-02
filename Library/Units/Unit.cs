using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Misc;

namespace Library.Units
{
	class Unit : IUnit
	{
		private float hp;
		private readonly IStrategy strategy;
		private static Random rand = new Random();
		private readonly List<string> infections = new List<string>();
		private readonly string name;
		private readonly Outfit armorSet;
		public Unit(IStrategy strategy, float hp, string name, Outfit armorSet)
		{
			this.hp = hp;
			this.name = name;
			this.armorSet = armorSet;
			this.strategy = strategy;
		}

		public void Attack(IUnit unit)
		{
			unit.Defense(rand.Next(5, 10) + armorSet.Attack);
		}

		public void Defense(float attack)
		{
			var hit = strategy.OnHit(attack) - armorSet.Defense;
			if (hit > 0)
				hp -= hit;
		}

		public void AddInfection(string v)
		{
			infections.Add(v);
		}

		public bool IsAlive { get { return hp > 0; } }

		public string Name
		{
			get
			{
				return name;
			}
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("\nName: " + Name + "\n");
			sb.Append("IsAlive: " + IsAlive + "\n");
			sb.Append("HP: " + hp + "\n");
			sb.Append("Infections:" + "\n");
			foreach (var infection in infections)
			{
				sb.Append(infection + "\n");
			}
			sb.Append(armorSet.ToString());

			return sb.ToString();
		}

		public void AcceptItem(Item item)
		{
			//item.VisitUnit(this);
		}
	}
}
