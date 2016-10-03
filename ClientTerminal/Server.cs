using ClientTerminal.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientTerminal
{
	public class Server : IDisposable
	{
		private readonly Service1Client sc = new Service1Client();

		public Server()
		{
			
		}

		public void Dispose()
		{
			((IDisposable)sc).Dispose();
		}

		public void Login(string userName)
		{

		}
	}
}
