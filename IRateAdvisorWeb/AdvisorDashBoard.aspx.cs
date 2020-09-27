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
            var _tier = Convert.ToInt32(Session["D_Tier"]);
            var total = Convert.ToDouble(Session["Total"]);
            var percents = (List<double>)Session["Percentages"];
            var values = (List<double>)Session["Rand values"];

            string[] tiers = { "Blue", "Bronze", "Silver", "Gold" };
            string[] colours = { "#2c5cde", "#ee9850", "#bfc1c3", "#e3b72e" };
            string displayTier = "";
            string displayNextTier = "";

            int DiscoveryTier = _tier;
            displayTier = tiers[DiscoveryTier - 1];

            CurrentTier1.InnerText = displayTier;
            CurrentTier1.Style.Add("color", colours[DiscoveryTier - 1]);



            int nextTier = DiscoveryTier;
            if (DiscoveryTier < 4) {

                nextTier = DiscoveryTier + 1;
            }

            displayNextTier = tiers[nextTier - 1];

            TierAbove.InnerText = displayNextTier;
            TierAbove.Style.Add("color", colours[nextTier - 1]);

            var shouldSpend = await client.KMeansAnalysis_getTierSpendAsync(total, nextTier);

            var tierAbovePercent = client.KMeansAnalysis_getClusterCenterAsync(total, nextTier);

            /* 1 - alcohol
             * 2 - takeout
             * 3 - cash
             * 4 - entertainment
             */

        }
        protected void ChartSetup(List<double> percents)
        {
            // make data points 

            string[] myLabels = { "Utilities", "Transport", "Rent", "Loans", "Saving", "Insurance", "Education", "Communication", "Takeout", " Groceries", "Alcohol", "Entertainment", "Personal", " Clothing", "Cash", "Other" };
            int counter = 0;
            List<System.Web.UI.DataVisualization.Charting.DataPoint> points1 = new List<DataPoint>();

            Series series1 = new Series();
            series1 = Chart1.Series["Testing"];

            foreach (var p in percents)
            {

                series1.Points.AddXY(myLabels[counter], p * 100);
                counter++;
            }
            ChartArea ca = Chart1.ChartAreas["ChartArea1"];
            series1.MarkerStyle = MarkerStyle.Circle;
            series1.ChartArea = ca.Name;

        }
        protected void secondSeriesSetup(List<double> Clusterpercents)
        {
            // make data points 

            string[] myLabels = { "Utilities", "Transport", "Rent", "Loans", "Saving", "Insurance", "Education", "Communication", "Takeout", " Groceries", "Alcohol", "Entertainment", "Personal", " Clothing", "Cash", "Other" };
            int counter = 0;
            List<System.Web.UI.DataVisualization.Charting.DataPoint> points1 = new List<DataPoint>();

            Series series2 = new Series();


            foreach (var p in Clusterpercents)
            {

                series2.Points.AddXY(myLabels[counter], p * 100);
                counter++;
            }
            ChartArea ca = Chart1.ChartAreas["ChartArea1"];

            series2.MarkerStyle = MarkerStyle.Circle;
            series2.ChartArea = ca.Name;

        }

    }


    
}


        
  
   
