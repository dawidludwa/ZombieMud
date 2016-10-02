using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Misc
{
	public abstract class ComponentItem : Item
	{
		protected readonly List<Item> items = new List<Item>();

		public ComponentItem(string Name, float Weight, float Size, List<Buff> buffs) : base(Name, Weight, Size, buffs)
		{
		}

		public abstract void AddItem(Item item);
		public abstract void RemoveItem(Item item);
		public abstract void ReplaceItem(Item oldItem, Item newItem);
	}
}
