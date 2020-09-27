using IRateAdvisorWeb.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IRateAdvisorWeb
{
    public partial class ScamResultsPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if(Session["QResults"] is null)
            {
                Response.Redirect("About.aspx");
            }

            var result = (EmployeeUserReport)Session["QResults"];
            string isScam = "";
            if (result.IsScam)
            {
                isScam = "a SCAM";
            }
            else
            {
                isScam = "NOT a scam";
            }


            string strInformation = $"The overall analysis declares this business venture is {isScam}. The likelihood of it being a scam is {result.ScamPercentage}%";
            informationLabel.InnerText = strInformation;
            Session["QResults"] = null;


        }
    }
}