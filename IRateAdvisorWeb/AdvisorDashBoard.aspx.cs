using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IRateAdvisorWeb.Utilities;
using IRateAdvisorWeb.Services;

namespace IRateAdvisorWeb
{
    public partial class AdvisorDashBoard : System.Web.UI.Page
    {
        Client client = new Client();

        protected async void Page_Load(object sender, EventArgs e)
        {
            var tier = Convert.ToInt32(Session["D_Tier"]);
            var total = Convert.ToDouble(Session["Total"]);
            var percents = (double[])Session["Percentages"];
            var values = (double[])Session["Rand values"];

     

           

            var DiscoveryTier = client.KMeansAnalysis_postDiscoveryTierAsync(total,percents);
        }
    }
}