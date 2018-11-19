using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Yammer
{
    public partial class concurrencyadd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int item1 = DateTime.Now.Second;

            lock (Global.Items)
            {
                Global.Items.Add(item1);
            }

            string result = "<h1>Add</h1>";

            result += string.Format("<span>{0}</span></br>", item1);


            this.Literal1.Text = result;
        }
    }
}