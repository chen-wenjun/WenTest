using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Raymark.APIWebServiceTest
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{









			int ran = 0;
			do
			{
				ran = new Random().Next(9999999);
			} 
			while (ran > 100000);

			string rand = ran.ToString("0000000");


			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}


	}

}
