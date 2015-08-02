using System;
using Microsoft.Owin.Hosting;

namespace OwinSelfHostExample.WebApi
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var host = "http://localhost:9000";
			using(WebApp.Start(host))
			{
				Console.WriteLine ("Server running on " + host);
				Console.WriteLine ("Press any key to shutdown.");
				Console.ReadLine ();
			}
		}
	}
}
