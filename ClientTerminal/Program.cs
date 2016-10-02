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
			using (Service1Client sc = new Service1Client())
			{
				var cred = sc.GetData(5);
				var ret = sc.GetDataUsingDataContract(new CompositeType() { BoolValue = true, StringValue = "bo tak" });
				var koks = sc.GetUserSetting(new User() { Name = "dupa" });
				Console.WriteLine(cred);
			}

			Console.ReadKey();
		}
	}
}
