using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientTerminal
{
	class KeyboardReader : IKeyboardReader
	{
		public string ReadLine()
		{
			Console.Write("/type# ");
			return Console.ReadLine();
		}
	}
}
