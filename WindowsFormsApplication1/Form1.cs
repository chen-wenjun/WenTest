using Microsoft.PointOfService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
	public partial class Form1 : Form
	{
		Scanner currScanner = null;

		public Form1()
		{
			InitializeComponent();

			//WriteOptionsFile();

			
			//// Load all installed "CashDrawer"
			//Microsoft.PointOfService.PosExplorer posExplorer = new Microsoft.PointOfService.PosExplorer();
			//Microsoft.PointOfService.DeviceCollection devCollection = posExplorer.GetDevices(DeviceType.Scanner);
			//if (devCollection.Count > 0)//if (devCollection.Count > posPr_no)
			//{
			//	//device = (Microsoft.PointOfService.PosPrinter)posExplorer.CreateInstance(devCollection[0]);.
			//	//device = (Microsoft.PointOfService.PosPrinter)posExplorer.CreateInstance(devCollection[posPr_no]);
			//	//---com_obj[posPr_no] = (Microsoft.PointOfService.PosPrinter)posExplorer.CreateInstance(devCollection[posPr_no]);
			//	//---Console.WriteLine("device= " + posPr_no.ToString("00"));

			//	foreach (DeviceInfo devv in devCollection)
			//	{
			//		if (devv.ServiceObjectName.Contains("MOTOROLA_SCANNER"))
			//			currScanner = (Scanner)posExplorer.CreateInstance(devv);

			//		//if (devCollection.IndexOf(devv) < devCollection.Count)
			//		//{
			//		//	com_obj[devCollection.IndexOf(devv)] = (Microsoft.PointOfService.CashDrawer)posExplorer.CreateInstance(devv);
			//		//}
			//	}
			//}

			//currScanner.Open();
			//currScanner.Claim(5000);
			//currScanner.DeviceEnabled = true;
			//currScanner.DataEventEnabled = true;

			////currScanner.DataEvent +=new DataEventHandler(Scanner_DataEvent);

			//System.Threading.Thread.Sleep(10000);

			//byte[] b = currScanner.ScanData;

		}

		private void Scanner_DataEvent(object sender, DataEventArgs e)
		{
			byte[] b = currScanner.ScanData;


			string str = "Raw Data: ";
			for (int i = 0; i < b.Length; i++)
				str += (b[i].ToString() + " ");
			str += "\r\n";

			str += "Formatted Data: ";
			b = currScanner.ScanDataLabel;
			for (int i = 0; i < b.Length; i++)
				str += (char)b[i];
			str += "\r\n";

			str += "Symbology: " + currScanner.ScanDataType + "\r\n";
			str += "\r\n";

			MessageBox.Show(str);
		}

		private void timerBtn_Click(object sender, EventArgs e)
		{
			// Create an event to signal the timeout count threshold in the 
			// timer callback.
			AutoResetEvent autoEvent = new AutoResetEvent(false);

			StatusChecker statusChecker = new StatusChecker(10);

			// Create an inferred delegate that invokes methods for the timer.
			TimerCallback tcb = statusChecker.CheckStatus;

			// Create a timer that signals the delegate to invoke  
			// CheckStatus after one second, and every 1/4 second  
			// thereafter.
			Console.WriteLine("{0} Creating timer.\n",
				DateTime.Now.ToString("h:mm:ss.fff"));
			System.Threading.Timer stateTimer = new System.Threading.Timer(tcb, autoEvent, 5000, 15000);

			// When autoEvent signals, change the period to every 
			// 1/2 second.
			autoEvent.WaitOne(60000, false);
			//stateTimer.Change(0, 500);
			//Console.WriteLine("\nChanging period.\n");

			//// When autoEvent signals the second time, dispose of  
			//// the timer.
			//autoEvent.WaitOne(5000, false);
			stateTimer.Dispose();
			Console.WriteLine("\nDestroying timer.");
		}

		private void watcherBtn_Click(object sender, EventArgs e)
		{
			string path = @"D:\Temp";
			FileSystemWatcher watcher = new FileSystemWatcher(path, "*.txt");
			watcher.Created += watcher_Created;
			watcher.EnableRaisingEvents = true;
		}

		void watcher_Created(object sender, FileSystemEventArgs e)
		{
			MessageBox.Show(string.Format("file '{0}' has been created.", e.Name));
			//((FileSystemWatcher)sender).EnableRaisingEvents = false;
		}

		private void timer2Btn_Click(object sender, EventArgs e)
		{
			// Create an event to signal the timeout count threshold in the 
			// timer callback.
			AutoResetEvent autoEvent = new AutoResetEvent(false);

			StatusChecker2 statusChecker2 = new StatusChecker2();

			// Create an inferred delegate that invokes methods for the timer.
			TimerCallback tcb = statusChecker2.CheckStatus;

			// Create a timer that signals the delegate to invoke  
			System.Threading.Timer stateTimer = new System.Threading.Timer(tcb, autoEvent, 2000, 2000);

			// Block the current thread for 60 seconds. When autoEvent signals, dispose of the timer.
			autoEvent.WaitOne(60000, false);
			stateTimer.Dispose();
		}

		public static void WriteOptionsFile()
		{
			try
			{
				FileStream optionsFile = File.Open(
					Path.Combine(Directory.GetCurrentDirectory(), "Options.xml"),
					FileMode.Create);

				string xmlContents = string.Format(
					@"<?xml version='1.0'?><RetaligentOptions><WebServiceBase>{0}</WebServiceBase><WebServiceCRMPath>CRM/</WebServiceCRMPath><WebServiceESPOfferPath>ESP/</WebServiceESPOfferPath><WebServiceGiftRegistryPath>Gift/GiftRegistry/</WebServiceGiftRegistryPath><WebServiceIntegrationPath>Integration/</WebServiceIntegrationPath><PreviousWebServiceUrls /></RetaligentOptions>",
					DateTime.Now);

				//SaksAgentV1a.Log.LogHelp_AgentPOS.WriteLog(@"C:\MyDebug", "WriteOptionsFile: " + xmlContents, false, false);


				byte[] optionsFileBytes = Encoding.ASCII.GetBytes(xmlContents);

				optionsFile.Write(
					optionsFileBytes,
					0,
					optionsFileBytes.Length);

				optionsFile.Flush();
				optionsFile.Close();
			}
			catch (Exception ex)
			{
				//Log.Log4netHelper.WriteLog("Utility->WriteOptionsFile", ex, Log.LogType.Error);
			}
		}

		private void checkUserIdentityTBox_Click(object sender, EventArgs e)
		{
			string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
			MessageBox.Show(userName);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			List<string> lines = new List<string>();
			lines.Add(DateTime.Now.ToString());
			lines.Add(System.Security.Principal.WindowsIdentity.GetCurrent().Name);
			lines.Add("............");
			File.AppendAllLines(@"D:\temp\testlog.txt", lines);
		}
	}


	class StatusChecker2
	{
		// This method is called by the timer delegate. 
		public void CheckStatus(Object stateInfo)
		{
			AutoResetEvent autoEvent = (AutoResetEvent)stateInfo;

			bool isDone = true;

			if (isDone)
			{
				// signal the main thread.
				autoEvent.Set();
			}
		}
	}

	class StatusChecker
	{
		private int invokeCount;
		private int maxCount;

		public StatusChecker(int count)
		{
			invokeCount = 0;
			maxCount = count;
		}

		// This method is called by the timer delegate. 
		public void CheckStatus(Object stateInfo)
		{
			AutoResetEvent autoEvent = (AutoResetEvent)stateInfo;
			Console.WriteLine("{0} Checking status {1,2}.",
				DateTime.Now.ToString("h:mm:ss.fff"),
				(++invokeCount).ToString());

			if (invokeCount == maxCount)
			{
				// Reset the counter and signal Main.
				invokeCount = 0;
				autoEvent.Set();
			}
		}
	}
}
