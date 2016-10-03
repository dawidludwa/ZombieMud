using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientTerminal
{
	public abstract class Command
	{
		protected readonly Server server;

		public Command(Server server)
		{
			this.server = server;
		}

		public abstract void Execute();
	}
}
