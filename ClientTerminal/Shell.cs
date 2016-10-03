using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientTerminal
{
	class Shell
	{
		private readonly ICommandParser parser;
		private readonly IKeyboardReader keyboardReader;

		public Shell(IKeyboardReader keyboardReader, ICommandParser parser)
		{
			this.parser = parser;
			this.keyboardReader = keyboardReader;
		}

		public void Run()
		{
			string line = null;
			while (line != "exit")
			{
				line = keyboardReader.ReadLine();
				parser.Parse(line);
			}
			
		}
	}
}
