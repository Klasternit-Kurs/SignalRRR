using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRRR.Server.Habovi
{
	public class TestHab : Hub
	{
		public void Test(string poruka)
		{
			Console.WriteLine("Javio se klijent sa : " + poruka);
			Clients.Caller.SendAsync("ZaServer", poruka.ToUpper());
		}
	}
}
