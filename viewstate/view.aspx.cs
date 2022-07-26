using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace viewstate
{
    public partial class view : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //protected void Button2_Click(object sender, EventArgs e)
        //{

        //}

        protected void BtnStore_Click(object sender, EventArgs e)
        {
            ViewState["uname"] = Txtuname.Text;
            ViewState["pass"] = Txtuname.Text;
            Txtuname.Text = "";
            Txtpswd.Text = "";



        }

        protected void Btnload_Click(object sender, EventArgs e)
        {
            string a = ViewState["uname"].ToString();
            string b = ViewState["uname"].ToString();
            Lbl3.Text = "your name is :" + a + "and the password : " + b;


        }
    }
}