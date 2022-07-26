using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace viewstate
{
    public partial class Assignment1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string[] str = new string[] { "select", "chevrolet", "jeep", "mercedes", "bmw" };
                for (int i = 0; i < str.Length; i++)
                {
                    DropDownList1.Items.Add(str[i]);
                }
            }
        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = DropDownList1.Text;
            Image1.ImageUrl = "~/money/" + str + ".jpg";

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = DropDownList1.SelectedIndex.ToString();
            if(DropDownList1.Text == "chevrolet")
            {
                Label1.Text = "Rs 6000000";
            }
            else if(DropDownList1.Text == "jeep")
                {
                Label1.Text = "Rs 88000000";
            }
            else if (DropDownList1.Text == "mercedes")
            {
                Label1.Text = "Rs 7900000";
            }
            else if (DropDownList1.Text == "bmw")
            {
                Label1.Text = "Rs 4000000";
            }
            else
            {
                Label1.Text = "";
            }
        }
    }
}