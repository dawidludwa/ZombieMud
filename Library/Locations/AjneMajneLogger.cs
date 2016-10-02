using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Locations
{
	class AjneMajneLogger : ILogger
	{
		public void WriteLine(string v)
		{
			Console.WriteLine(DateTime.Now.ToString() + " "+ v);
		}
	}
}
