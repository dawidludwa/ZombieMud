using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientTerminal
{
	class State
	{
		public State(string currentUser)
		{
			CurrentUser = currentUser;
		}
		public string CurrentUser { get; private set; }

		//string CurrentUser { get; private set; }
	}
}
