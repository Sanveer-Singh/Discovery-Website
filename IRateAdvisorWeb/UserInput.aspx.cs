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
                    _PersonalFamily,_Clothing,_Cash,_Other,_Income = "";

            double[] values = new double[16];

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
            _Income = Income.Text;

            values[0] = Convert.ToDouble(_Utilities);
            values[1] = Convert.ToDouble(_Transport_Petrol);
            values[2] = Convert.ToDouble(_Rent);
            values[3] = Convert.ToDouble(_Paying_Loans);
            values[4] = Convert.ToDouble(_Saving_Investment);
            values[5] = Convert.ToDouble(_Insurance_Medical);
            values[6] = Convert.ToDouble(_Education);
            values[7] = Convert.ToDouble(_Takeoutfood);
            values[8] = Convert.ToDouble(_Groceries);
            values[9] = Convert.ToDouble(_Alcohol_Cigarettes);
            values[10] = Convert.ToDouble(_Entertainment);
            values[11] = Convert.ToDouble(_PersonalFamily);
            values[12] = Convert.ToDouble(_Clothing);
            values[13] = Convert.ToDouble(_Cash);
            values[14] = Convert.ToDouble(_Other);
            values[15] = Convert.ToDouble(_Communication);

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
            
        }
    }
}