using ClientTerminal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientTerminal
{
	class CommandParser : ICommandParser
	{
		//Command command
		private List<Command> commands = new List<Command>();

		public void Parse(string line)
		{
			if (line.Contains("login"))
			{
				var arg = line.Replace("login", "").Trim();
				var comm = commands.Where(c => c.GetType().Name.Contains("Login")).FirstOrDefault();
				if (comm != null)
					comm.Execute();
			}
		}

		internal ICommandParser AddCommand(Command command)
		{
			if (!commands.Contains(command))
				commands.Add(command);

			return this;
		}
	}
}
