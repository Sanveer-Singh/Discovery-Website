using IRateAdvisorWeb.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IRateAdvisorWeb
{
    public partial class Register : System.Web.UI.Page
    {
        private bool isBusy = false;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected async void btnLoginSubmit_Click(object sender, EventArgs e)
        {
            if (isBusy) return;
            isBusy = true;

            string name = RegisterName.Text;
            string surname = RegisterSurname.Text;
            string username = RegisterUserName.Text;
            string password = RegisterPassword1.Value;
            string Confirmpassword = RegisterPassword2.Value;

            if (string.IsNullOrEmpty(name))
            {
                return;
            }

            if (string.IsNullOrEmpty(surname))
            {
                return;
            }

            if (string.IsNullOrEmpty(username))
            {
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                return;

            }

            if (string.IsNullOrEmpty(Confirmpassword))
            {
                return;
            }
            if (!Confirmpassword.Equals(password))
            {
                return;
            }



            using (Client client = new Client())
            {
                try
                {
                    var response = await client.GeneralUsers_RegisterUserAsync(name, surname, username, password);
                    //set the session variables
                    if (response != null)
                    {
                        //success
                        Response.Redirect("Login.aspx", false);
                    }
                    else
                    {
                        //failure
                    }

                }
                catch (Exception ex)
                {

                }
                finally
                {
                    isBusy = false;
                }
            }
        }
    }
}