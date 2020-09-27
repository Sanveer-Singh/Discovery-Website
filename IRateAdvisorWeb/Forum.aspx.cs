using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IRateAdvisorWeb.Utilities;
using IRateAdvisorWeb.Services;
using System.Web.Management;
using System.Threading.Tasks;

namespace IRateAdvisorWeb
{
    public partial class Forum : System.Web.UI.Page
    {
        Client client = new Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            //TODO : Service call here to get object
            string display = "";
            string imgURL = "https://d1yjjnpx0p53s8.cloudfront.net/styles/logo-thumbnail/s3/012020/thumbnail-discovery_logo_-_full_colour.png?o6Grbgwj5kb6vpMCXGaY_A5aeNuJTERJ&itok=mcA6_zSp";
            for(int i = 0; i < 10; i++)
            {
                display += HtmlStringGenerator.GetDynamicReportDisplayString($"This is test{i}", imgURL, "This is description", "Field1", "This is description 2", "Field2", "Description 3", "Field 3");
                display += "</br>"; 
            }


            displayDiv.InnerHtml = display;
        }

        private async Task<EmployeeUserReport> getScam(string scamName)
        {
            EmployeeUserReport temp = null;
            try
            {
                var stuff = await client.EmployeeUserReports_GetScamByNameAsync(scamName);

                temp = new EmployeeUserReport
                {
                    IsEmployeeReport = stuff.IsEmployeeReport,
                    IsScam = stuff.IsScam,
                    ReportedName = stuff.ReportedName,
                    ReportId = stuff.ReportId,
                    ScamPercentage = stuff.ScamPercentage,
                    UserId = stuff.UserId,
                    User = stuff.User,
                    Answer = stuff.Answer,
                    TagReportBridge = stuff.TagReportBridge
                };
            }
            catch(Exception ex)
            {
                error.Text = "Could not find scam";
            }

            if(temp != null)
            {
                return temp;
            }

            return temp;
        }

        protected async void btnSearch_Click(object sender, EventArgs e)
        {
            string display = "";
            EmployeeUserReport userReport = await getScam(searchBox.Text);
            //display = Utilities.HtmlStringGenerator();

            displayDiv.InnerHtml = display;
        }
    }
}