using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IRateAdvisorWeb
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["USERID"] != null)
            {
                login_register.HRef = "Logout.aspx";
                login_register.InnerHtml = "<div>Logout</div>";

            }
            else
            {
                login_register.HRef = "Login.aspx";
                login_register.InnerHtml = "<div>Login</div>";
            }
        }
    }
}