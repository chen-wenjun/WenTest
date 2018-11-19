using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNETWebApplication
{
	public partial class _Default : Page
	{
		#region ViewState Members

		/// <summary>
		/// The zero-based index of the current page of search results.
		/// </summary>
		private int CurrentPageIndex
		{
			get
			{
				if (this.ViewState["CurrentPageIndex"] == null)
					return 0;

				return Convert.ToInt32(this.ViewState["CurrentPageIndex"]);
			}

			set
			{
				this.ViewState["CurrentPageIndex"] = value;
			}
		}

		/// <summary>
		/// The total number of pages of results for the current search parameters.
		/// </summary>
		private int TotalPageCount
		{
			get
			{
				if (this.ViewState["TotalPageCount"] == null)
					return 0;

				return Convert.ToInt32(this.ViewState["TotalPageCount"]);
			}

			set
			{
				this.ViewState["TotalPageCount"] = value;
			}
		}

		/// <summary>
		/// The total number of results for the current search parameters.
		/// </summary>
		private int TotalResultCount
		{
			get
			{
				if (this.ViewState["TotalResultCount"] == null)
					return 0;

				return Convert.ToInt32(this.ViewState["TotalResultCount"]);
			}

			set
			{
				this.ViewState["TotalResultCount"] = value;
			}
		}

		/// <summary>
		/// Property storing Sorting Column Name
		/// </summary>
		private string SortColumn
		{
			get
			{
				if (this.ViewState["SortColumn"] == null)
					return "LastName";

				return Convert.ToString(this.ViewState["SortColumn"]);
			}
			set
			{
				this.ViewState["SortColumn"] = value;
			}
		}

		#endregion


		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				this.SortColumn = "column1";


			}
			else
			{
				string sortColumn = this.SortColumn;

			}



			//string url = Request.QueryString["url"];

			//Session["url"] = url;


			////Response.Write(Session["url"]);

			////Response.End();

			//Response.Redirect(url);
		}

		protected void Button1_Click(object sender, EventArgs e)
		{

		}
	}
}