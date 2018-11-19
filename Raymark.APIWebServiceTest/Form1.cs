using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Raymark.APIWebServiceTest
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string clientId = clientIdTBox.Text.Trim();
			
			APIWebServiceTest.Raymark.APIWebReference.ClientWebService ws = new Raymark.APIWebReference.ClientWebService();
			ws.Url = urlTBox.Text.Trim();

			XmlNode oXmlNode = ws.GetClientEmailAddressesForPOS(clientId);

			MessageBox.Show(string.Format("Successful! {0}", oXmlNode.InnerXml));
		}
	}
}
