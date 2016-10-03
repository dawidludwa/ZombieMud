using ClientTerminal.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientTerminal
{
	class Program
	{
		static void Main(string[] args)
		{
			using (Server server = new Server())
			{
				var command = new LoginCommand(server, "kutas");
				Shell shell = new Shell(new KeyboardReader(), new CommandParser().AddCommand(command));
				shell.Run();
			}
		}
	}
}
