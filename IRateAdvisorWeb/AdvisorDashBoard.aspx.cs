using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IRateAdvisorWeb.Utilities;

namespace IRateAdvisorWeb
{
    public partial class AdvisorDashBoard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Display.InnerHtml  = HtmlStringGenerator.GetDynamicReportDisplayString("This is a name", "https://wallpapercave.com/wp/wp2446333.jpg", "Field desc1","Field1","Field desc2", "Field2", "Field desc3", "Field3");

        }
    }
}