using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Yammer
{
    public partial class concurrencyloop : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string result = "<h1>Loop</h1>";

            lock (Global.Items)
            {
                foreach (int item in Global.Items)
                {
                    Thread.Sleep(500);
                    result += string.Format("<span>{0}</span></br>", item);
                }
            }
            //for (int i = 0; i < Global.Items.Count; i++ )
            //{
            //    Thread.Sleep(500);
            //    result += string.Format("<span>{0}</span></br>", Global.Items[i]);
            //}

            this.Literal1.Text = result;
        }
    }
}