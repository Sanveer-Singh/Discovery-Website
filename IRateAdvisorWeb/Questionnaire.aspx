<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Questionnaire.aspx.cs" Inherits="IRateAdvisorWeb.Questionnaire" Async="true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server" >

         <script src="js/jquery.js"></script>
         <script type="text/javascript">

             $(document).ready(function () {

                 //FindQuestions();
              
                 $("#btnSubmitAnswers").on('click touch', function () {
                     FindQuestions();
               });
           });

             //function submit() {
             //    FindQuestions
   
             //};

             function FindQuestions() {
                 var strKV = "";
                 //foreach label with the class question that is set in the c# file
                 $(".question").each(function () {
                     //get the ID of the label
                     var ID = $(this).attr('id');
                     //get the text box
                     var textBox = $("#A" + ID);
                     strKV += ID + ":" + textBox.val()+"|";
                 });

                 //alert("Questionnaire.aspx?answers=" + strKV);
                 window.location.href = "Questionnaire.aspx?answers=" + strKV;
                 return false;

             };

         </script>
     <!-- Content
		============================================= -->
    <section id="content">

        <div class="content-wrap">

            <div class="container clearfix">

                <div class="tabs divcenter nobottommargin clearfix" style="max-width: 500px;">

                   <%-- <div class="btn-group">
                        <div class="button">
                            <a href="#tab-login" style="text-decoration: none; color: white">Login</a>
                        </div>

                        <div class="button" style="background-color: #EEEEEE;" id="btnRegister" runat="server">
                        </div>

                    </div>--%>



                    <div class="tab-container">

                        <div class="tab-content clearfix">
                            <div class="panel panel-default nobottommargin">
                                <div class="panel-body" style="padding: 40px;">
                                    <div class="nobottommargin" id="QuestionContainer" runat="server">
                                        <%--*************************  questions   ************************************--%>
                                            <%--("<div class='fancy-title title-center title-dotted-border'>");
                                               ( "<h3>Answer the following questions</h3>");
                                           (" </div>");

                                       
                                           (" <div class='col_full'>");
                                               (" <label for='loginUsername'>Username:</label>");
                                             ("   <input type='text' tabindex='1' placeholder='Username' class='sm-form-control required question'/>");
                                            ("</div>");

                                            <div class="col_full">
                                                <label for="loginPassword">Password:</label>
                                                <input type="password" id="Password1" name="loginPassword" tabindex="2" value="" class="sm-form-control required" placeholder="Password" runat="server"/>
                                                <!-- the visibility switch-->
                                            <br/>
                                            </div>

                                            <div class="col_full" id="error1" runat="server" style="color: red">
                                            </div>
                                            <div class="col_full" id="error" style="color: red">
                                            </div>--%>


                            
                                    </div>
                                            <div class="col_full nobottommargin">

                                                <%--<input type="button" class="button button-3d button-circle button-large" id="loginSubmit" name="loginSubmit" value="login" onclick="" />--%>
                                               <input type="button" class="button button-3d button-circle button-large" id="btnSubmitAnswers" style= "background-color : #1E90FF" value="Submit" />
                                                <a href="About.aspx" class="button button-3d button-circle button-large button-black"  > Cancel </a>

                                                   <%-- <a href="Register.aspx" class="fright" target="_blank" style ="color : #1E90FF">Click here to register.</a>--%>
                                            </div>
                                </div>
                            </div>
                        </div>


                    </div>

                </div>

            </div>

        </div>

    </section>
    <!-- #content end -->
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Footer1" runat="server">
</asp:Content>
