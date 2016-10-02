using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Units
{
	class UnitFactory : Factory
	{
		private static Random rand = new Random();
		private readonly string names = "JAMES JOHN ROBERT MICHAEL WILLIAM DAVID RICHARD CHARLES JOSEPH THOMAS CHRISTOPHER DANIEL PAUL MARK DONALD GEORGE KENNETH STEVEN EDWARD BRIAN RONALD ANTHONY KEVIN JASON MATTHEW";
		private readonly string lastnames = "SMITH JOHNSON WILLIAMS JONES BROWN DAVIS MILLER WILSON MOORE TAYLOR ANDERSON THOMAS JACKSON WHITE HARRIS MARTIN THOMPSON GARCIA MARTINEZ ROBINSON CLARK RODRIGUEZ LEWIS LEE WALKER";

		public UnitFactory(IStrategyFactory strategyFactory) : base(strategyFactory)
		{

		}

		private string GetName()
		{
			var col = names.ToLower().Split(' ').ToList();
			var lcol = lastnames.ToLower().Split(' ').ToList();

			return UppercaseFirst(col[rand.Next(col.Count)]) + " " + UppercaseFirst(lcol[rand.Next(lcol.Count)]);
		}

		private string UppercaseFirst(string s)
		{
			if (string.IsNullOrEmpty(s))
			{
				return string.Empty;
			}
			char[] a = s.ToCharArray();
			a[0] = char.ToUpper(a[0]);
			return new string(a);
		}


		public override IUnit Create()
		{
			Outfit armorSet = Outfit.Empty();
			return new Unit(strategyFactory.Create(), 100, GetName(), armorSet);
		}
	}
}
