using IRateAdvisorWeb.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IRateAdvisorWeb
{
    public partial class Questionnaire : System.Web.UI.Page
    {
        protected  void Page_Load(object sender, EventArgs e)      
        {
            //if (Session["USERID"] == null)
            //{
            //    Response.Redirect("Login.aspx", false);
            //}

             if (Request.QueryString["answers"] != null)
            {
                string answers = Request.QueryString["answers"];
                string[] answerBits = answers.Split('|');
                List<Answer> answerList = new List<Answer>();
                foreach(var bit in answerBits)
                {
                    if (bit.Length == 0) continue;

                    var kvPair = bit.Split(':');
                    string strAnswer = kvPair[1].ToLower();
                    bool blnAnswer = false;
                  if(strAnswer.Contains("yes")|| strAnswer.Contains("true"))
                    {
                        blnAnswer = true;
                    }
                    else
                    {
                        blnAnswer = false;
                    }
                    Answer answer = new Answer { Qid = Convert.ToInt32(kvPair[0]), Answer1 = blnAnswer, };
                    answerList.Add(answer);
                }

                SubmitAnswers(answerList);
            }
            else
            {

            SetQuestions();
            }
        }

        public async void SubmitAnswers(List<Answer> answerList)
        {
            try
            {
                using (Client client = new Client())
                {
                    var response = await client.Answers_PostAnswersAsync(Convert.ToInt32(Session["USERID"]), answerList);
                    if (response != null)
                    {
                        Response.Redirect("About.aspx", false);
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private async void SetQuestions()
        {
            try
            {
                using(Client client = new Client())
                {
                    var response = await client.Questions_GetQuestionsAllAsync();

                    if(response != null)
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.Append("<div class='fancy-title title-center title-dotted-border'>");
                        sb.Append("<h3>Answer the following questions</h3>");
                        sb.Append(" </div>");

                        int counter = 1;
                        foreach (var  question in response)
                        {
                            sb.Append("<div class='col_full'>");
                            sb.Append($"<label id='{question.Qid}' class='question'>{question.DisplayString}:</label>");

                            sb.Append($"<label >Yes &nbsp;</label>");
                            sb.Append($"<input class='checkbox-inline' type='checkbox'  id='A{question.Qid}' value='true'>");
                            //sb.Append($"<input type='text' tabindex='{counter}' id='A{question.Qid}' class='sm-form-control required'/>");
                            sb.Append("</div>");
                            counter++;
                        }

                        QuestionContainer.InnerHtml = sb.ToString();
                    }
                }
            }catch(Exception ex)
            {

            }
        }

       
    }
}