using System;

namespace ClientTerminal
{
	public class LoginCommand : Command
	{
		public LoginCommand(Server server) : base(server)
		{
		}

		public override void Execute()
		{
			//server.Login(userName);
		}
	}
}