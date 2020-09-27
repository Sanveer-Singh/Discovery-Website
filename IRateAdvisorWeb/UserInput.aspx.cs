using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IRateAdvisorWeb.Services;

namespace IRateAdvisorWeb
{
    public partial class UserInput : System.Web.UI.Page
    {
        Client client = new Client();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected async void btnSubmit_Click(object sender, EventArgs e)
        {
            string _Utilities,_Transport_Petrol, _Rent , _Paying_Loans, 
                    _Saving_Investment, _Insurance_Medical,_Education,_Communication,
                    _Takeoutfood,_Groceries,_Alcohol_Cigarettes,_Entertainment,
                    _PersonalFamily,_Clothing,_Cash,_Other = "";

            List<double> values = new List<double>();

            _Utilities = Utilities.Text;
            _Transport_Petrol = Transport.Text;
            _Rent = Rent.Text;
            _Paying_Loans = Loans.Text;
            _Saving_Investment = Saving.Text;
            _Insurance_Medical = Insurance.Text;
            _Education = Education.Text;
            _Takeoutfood = Takeout.Text;
            _Groceries = Groceries.Text;
            _Alcohol_Cigarettes = Alcohol.Text;
            _Entertainment = Entertainment.Text;
            _PersonalFamily = Personal.Text;
            _Clothing = Clothing.Text;
            _Cash = Cash.Text;
            _Other = Other.Text;
            _Communication = Communication.Text;


            values.Add(Convert.ToDouble(_Utilities));
            values.Add(Convert.ToDouble(_Transport_Petrol));
            values.Add(Convert.ToDouble(_Rent));
            values.Add(Convert.ToDouble(_Paying_Loans));
            values.Add(Convert.ToDouble(_Saving_Investment));
            values.Add(Convert.ToDouble(_Insurance_Medical));
            values.Add(Convert.ToDouble(_Education));
            values.Add(Convert.ToDouble(_Takeoutfood));
            values.Add(Convert.ToDouble(_Groceries));
            values.Add(Convert.ToDouble(_Alcohol_Cigarettes));
            values.Add(Convert.ToDouble(_Entertainment));
            values.Add(Convert.ToDouble(_PersonalFamily));
            values.Add(Convert.ToDouble(_Clothing));
            values.Add(Convert.ToDouble(_Cash));
            values.Add(Convert.ToDouble(_Other));
            values.Add(Convert.ToDouble(_Communication));

            double total = values.Sum();
            List<double> percents = null;
            try
            {
               var temp = await client.KMeansAnalysis_postRandToPercentAsync(values);
                percents = temp.ToList();
            }
            catch (Exception ex) 
            { 

            }

            int tier = await client.KMeansAnalysis_postDiscoveryTierAsync(total, percents);

            Session["D_Tier"] = tier;
            Session["Total"] = total;
            Session["Percentages"] = percents;
            Session["Rand values"] = values;

            Response.Redirect("AdvisorDashboard.aspx", false);


        }
    }
}