using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectCloudApp_AkhilMugeshMicheal
{
    public partial class Netbanking : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label3.Visible = false;
        }
            protected void Button1_Click(object sender, EventArgs e)
            {
                if (TextBox1.Text == "Username" & TextBox2.Text == "Password")
                {
                    Response.Redirect("NetBankingHome.aspx");

                }
                else { Label3.Text = "Invalid username or password"; Label3.Visible = true; }
            }
        }
    }
