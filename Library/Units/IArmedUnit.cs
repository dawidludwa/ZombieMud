using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Units
{
	interface IArmedUnit 
	{
		void Attack(IUnit unit);
		void Defense(float attack);
	}
}
