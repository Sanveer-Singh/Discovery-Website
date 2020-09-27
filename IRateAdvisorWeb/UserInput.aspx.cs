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

        protected void btnSubmit_Click(object sender, EventArgs e)
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
            values[1] = Convert.ToDouble(_Rent);
            values[1] = Convert.ToDouble(_Paying_Loans);
            values[1] = Convert.ToDouble(_Saving_Investment);
            values[1] = Convert.ToDouble(_Insurance_Medical);
            values[1] = Convert.ToDouble(_Education);
            values[1] = Convert.ToDouble(_Takeoutfood);
            values[1] = Convert.ToDouble(_Groceries);
            values[1] = Convert.ToDouble(_Alcohol_Cigarettes);
            values[1] = Convert.ToDouble(_Entertainment);
            values[1] = Convert.ToDouble(_PersonalFamily);
            values[1] = Convert.ToDouble(_Clothing);
            values[1] = Convert.ToDouble(_Cash);
            values[1] = Convert.ToDouble(_Other);
            values[1] = Convert.ToDouble(_Communication);


            
        }
    }
}