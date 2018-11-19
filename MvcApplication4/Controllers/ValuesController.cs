using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcApplication4.Controllers
{
	public class ValuesController : ApiController
	{
		// GET api/values
		public IEnumerable<string> Get()
		{
			ProcessStartInfo i = new ProcessStartInfo();
			i.UseShellExecute = true;
			i.WindowStyle = ProcessWindowStyle.Normal;
			i.CreateNoWindow = false;
			i.FileName = @"D:\Projects\Wen.Try2012\WenTest\WindowsFormsApplication1\bin\Debug\WindowsFormsApplication1.exe";
			//i.FileName = @"Notepad.exe";
			i.Arguments = "";

			i.UseShellExecute = false;
			i.Domain = "raymarkx.com";
			i.UserName = "wch";
			//i.Password = "cwj109@gmail.com";
			System.Security.SecureString ssPwd = new System.Security.SecureString();
			string password = "cwj109@gmail.com";
			for (int x = 0; x < password.Length; x++)
			{
				ssPwd.AppendChar(password[x]);
			}
			i.Password = ssPwd;

			Process pp = Process.Start(i);


			return new string[] { "value4.01", "value4.02" };
		}

		// GET api/values/5
		public string Get(int id)
		{
			return "value";
		}

		// POST api/values
		public void Post([FromBody]string value)
		{
		}

		// PUT api/values/5
		public void Put(int id, [FromBody]string value)
		{
		}

		// DELETE api/values/5
		public void Delete(int id)
		{
		}
	}
}