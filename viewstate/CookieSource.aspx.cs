using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace viewstate
{
    public partial class CookieSource : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnRedirect_Click(object sender, EventArgs e)
        {
            Response.Cookies["d1"].Value = Txtuname.Text;

            Response.Cookies["d2"].Value = Txtpswd.Text;
            Response.Redirect("CookieDest.aspx");
        }
    }
}