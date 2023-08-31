using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppSecureSM
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            { LblMsg.Visible = false;
            }
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            LblMsg.Visible = true;
            if(string.IsNullOrEmpty(TxtName.Text) || string.IsNullOrEmpty(TxtPwd.Text))
                    {
                LblMsg.Text = "Please Provide User Name and Password!!!";

            }
            else{
                if ((TxtName.Text == "sam") && (TxtPwd.Text == "sam@1234"))
                {
                    FormsAuthentication.RedirectFromLoginPage(TxtName.Text, true);
                    Response.Redirect("Home.aspx");
                }
                else { LblMsg.Text = "Either User Nmae or Password Incorrect!!!"; }
            }
        }
    }
}