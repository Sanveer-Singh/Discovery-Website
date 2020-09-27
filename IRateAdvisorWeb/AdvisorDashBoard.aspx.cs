using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.DataVisualization.Charting;
using System.Web.UI.WebControls;
using IRateAdvisorWeb.Utilities;

namespace IRateAdvisorWeb
{
    public partial class AdvisorDashBoard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         
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