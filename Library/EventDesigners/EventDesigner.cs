using Library.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.EventDesigners
{
	class EventDesigner
	{
		private readonly float percentage;
		private readonly IFactory unitFactory;
		private static Random rand = new Random();

		public EventDesigner(IFactory unitFactory, float percentage)
		{
			this.percentage = percentage;
			this.unitFactory = unitFactory;
		}

		public IUnit CreateEvent()
		{
			return unitFactory.Create();
		}

		//private List<>
		//void GetEvent()
	}
}
