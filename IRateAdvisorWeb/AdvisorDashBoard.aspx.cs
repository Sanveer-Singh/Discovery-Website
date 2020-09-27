using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.DataVisualization.Charting;
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
        
        protected void ChartSetup()
        {
            // make data points 
            List<double> percents = new List<double>() ;
            string[] myLabels = { "Utilities", "Transport", "Rent", "Loans", "Saving", "Insurance", "Education", "Communication", "Takeout"," Groceries", "Alcohol", "Entertainment", "Personal"," Clothing", "Cash", "Other" }; 
            int counter = 0;
            List<System.Web.UI.DataVisualization.Charting.DataPoint > points1 = new List<DataPoint>();
            // Series series1 = PetViewsPerMonth.Series["viewsPerMonth"];
            Series series1 = new Series();
       
            
            foreach (var p in percents)
            {
                DataPoint dp = new DataPoint(p,myLabels[counter]);
                series1.Points.AddXY(p, myLabels[counter]);
                counter++;
            }
    

        }
    }
}