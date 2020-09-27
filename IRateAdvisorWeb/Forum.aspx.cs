using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IRateAdvisorWeb.Utilities;

namespace IRateAdvisorWeb
{
    public partial class Forum : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //TODO : Service call here to get object
            string display = "";
            string imgURL = "https://d1yjjnpx0p53s8.cloudfront.net/styles/logo-thumbnail/s3/012020/thumbnail-discovery_logo_-_full_colour.png?o6Grbgwj5kb6vpMCXGaY_A5aeNuJTERJ&itok=mcA6_zSp";
            
            display += HtmlStringGenerator.GetDynamicReportDisplayString("This is test", imgURL, "This is description", "Field1", "This is description 2", "Field2", "Description 3", "Field 3");


            displayDiv.InnerHtml = display;
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}