using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestLicenseWin.LicenseActivation;

namespace TestLicenseWin
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			TestLicenseWin.LicenseActivation.WebActivateLicenseSoapClient client = new WebActivateLicenseSoapClient();
			String result = client.GetActivationKey("00201101010100000000000", "3031384A6A6C58384C2F2F58717352544C54502F6E426D6C48656E337762325A322F4171554741726F666647717266326F6F68394B3966513D3D");




			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
