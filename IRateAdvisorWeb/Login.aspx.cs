﻿using IRateAdvisorWeb.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IRateAdvisorWeb
{
    public partial class Login : System.Web.UI.Page
    {
        private bool isBusy= false;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected async void btnLoginSubmit_Click(object sender, EventArgs e)
        {
            if (isBusy) return;
            isBusy = true;
            // steps :
            // get input from the form 

            // sanatize input (Optional)

            // test via client - get results

            // set up session 

            // edit highlighted navbar links 

            //==== text box
            string username = LoginUserName.Text;
            // ===label of type input
            string password = Password1.Value;

            using(Client client = new Client())
            {
                try
                {
                    var response = await client.GeneralUsers_LoginUserAsync(username, password);
                    //set the session variables
                    if(response != null)
                    {
                        Session["USERID"] = response.UserId;
                        Session["USERNAME"] = response.Username;

                        var user = await client.Users_GetUsersAsync(response.UserId);

                        if(user != null)
                        {
                            Session["CLUSTERID"] = user.ClusterId;


                        }

                        var employee = await client.


                    }

                }catch(Exception ex)
                {

                }
                finally
                {
                    isBusy = false;
                }
            }

           
            //IRateAdvisorWeb.Client client = new IRateAdvisorWeb.Client();
            // var result = await client.LoginUserAsync(Username,Pass);
            // user my user = (IRateAdvisorWeb.Client.User )result
            // if (result is null)
            //{
            //
            //  SetError1("your username or password is incorrect")
            //}
            // else 
            //{
            // so
            //Session["ID"] = result.UserId;
            //}
        }
    }
}