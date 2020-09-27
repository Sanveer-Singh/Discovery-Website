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
            var percents = (List<double>)Session["Percentages"];
            var values = (List<double>)Session["Rand values"];

            total = 6500;
            percents = new List<double>() { 0.013559558966619603,  0.021568789085555148,  0.07443994697088253,  0.004471670403518764,  0.04601229953145287,  0.0026455100959500303,
                    0.0023080340122537766,  0.0023139639039568677,  0.03642384300619745,  0.08713971882768004,  0.037200004128613705,  0.010293084598351293,  0.02418201252185387, 
                    0.01313520361773447,  0.0851135717252017,  0.022866715353187465};


            string[] tiers = { "Bronze", "Silver", "Gold", "Diamond" };
            string displayTier = "";
            string displayNextTier = "";

            int DiscoveryTier = await client.KMeansAnalysis_postDiscoveryTierAsync(total, percents);
            displayTier = tiers[DiscoveryTier];
            int nextTier = DiscoveryTier;
            if (DiscoveryTier < 4) {

                nextTier = DiscoveryTier + 1;
            }

            displayNextTier = tiers[nextTier];

            var shouldSpend = client.KMeansAnalysis_getTierSpendAsync(total,nextTier);

            
            
        }
    }
}