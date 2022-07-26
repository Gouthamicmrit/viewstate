using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace viewstate
{
    public partial class QueryDest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnReceive_Click(object sender, EventArgs e)
        {
            lb1.Text = Request.QueryString["uname"];
            lbl2.Text = Request.QueryString["Password"];

        }
    }
}