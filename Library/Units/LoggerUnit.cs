using Library.Locations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Misc;

namespace Library.Units
{
	public class LoggerUnit : IUnit
	{
		private IUnit unit;
		private ILogger logger;

		public LoggerUnit(IUnit unit, ILogger logger)
		{
			this.unit = unit;
			this.logger = logger;
			logger.WriteLine(unit.ToString());
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
				return unit.Name;
			}
		}

		public void AddInfection(string v)
		{
			logger.WriteLine(unit.Name + " AddInfection " + v);
			unit.AddInfection(v);
		}

		public void Attack(IUnit unit)
		{
			logger.WriteLine(this.unit.Name + " Attack -> " + unit.Name);
			this.unit.Attack(unit);
		}

		public void Defense(float attack)
		{
			logger.WriteLine(unit.Name + " get hit " + attack);
			unit.Defense(attack);
		}

		public void AcceptItem(Item item)
		{
			throw new NotImplementedException();
		}

		public override string ToString()
		{
			return base.ToString();
		}
	}
}
