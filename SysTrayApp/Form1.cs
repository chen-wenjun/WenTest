using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysTrayApp
{
	public partial class Form1 : Form
	{
		private Form2 frm2;

		public Form1()
		{
			InitializeComponent();
			frm2 = new Form2();

		}

		private void ExitItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void contextMenuStrip1_Click(object sender, EventArgs e)
		{

		}

		private void notifyIcon1_Click(object sender, EventArgs e)
		{
		}

		private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				frm2.Show();

			}
		}
	}
}
