using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Misc
{
	class Clothes : ComponentItem
	{
		public Clothes(string Name, float Weight, float Size, List<Buff> buffs) : base(Name, Weight, Size, buffs)
		{
		}

		public override void AddItem(Item item)
		{
			if (!items.Contains(item))
				items.Add(item);
			else
				throw new ItemAlreadyExistException(this, item);
		}

		public override void RemoveItem(Item item)
		{
			if (items.Contains(item))
				items.Remove(item);
			else
				throw new ItemNotExistException(this, item);
		}

		public override void ReplaceItem(Item oldItem, Item newItem)
		{
				AddItem(newItem);
				RemoveItem(oldItem);
		}
	}
}
