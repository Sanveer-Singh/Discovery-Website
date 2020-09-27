<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="UserInput.aspx.cs" Inherits="IRateAdvisorWeb.UserInput" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <script src="js/jquery.js"></script>
    <script type="text/javascript">
        
            $("#loginSubmit").on("click touch", function () {
                $("#error").text("");
                var username = $("#loginUsername").val();
                var pass = $("#Password1").val();
                if (username.length == 0) {
                    $("#error").text("Please fill in your username");
                    return;
                } 
                else {
                    var url = getUrlVars();
                    console.log(url);

                    if (url["VALUES"] != null && url["CONFIRM"] != null) {
                        var strFull = url["FULL"] != null ? "&FULL=" + url["FULL"] : "";
                        window.location.href = "login.aspx?SUBMIT=TRUE&USER=" + username + "&PASS=" + pass + "&URL=" + url["URL"] + "&VALUES=" + url["VALUES"] + "&CONFIRM=" + url["CONFIRM"] + strFull;
                    } else if (url["URL"] != null) {
                        if (url["INVID"] != null) {
                            window.location.href = "login.aspx?SUBMIT=TRUE&USER=" + username + "&PASS=" + pass + "&URL=" + url["URL"] + "&INVID=" + url["INVID"];
                        } else {
                            window.location.href = "login.aspx?SUBMIT=TRUE&USER=" + username + "&PASS=" + pass + "&URL=" + url["URL"];
                        }
                    } else {
                        window.location.href = "login.aspx?SUBMIT=TRUE&USER=" + username + "&PASS=" + pass + "&URL=Home.aspx";
                    }
                }
            });
            $(document).on('keypress', 'input,select', function (e) {
                if (e.which == 13) {
                    e.preventDefault();
                    var $next = $('[tabIndex=' + (+this.tabIndex + 1) + ']');
                    console.log($next.length);
                    if (!$next.length) {
                        $next = $('[tabIndex=1]');
                    }
                    $next.focus();
                }
            });
        });
        function getUrlVars() {
            var vars = [], hash;
            var hashes = window.location.href.slice(window.location.href.indexOf('?') + 1).split('&');
            for (var i = 0; i < hashes.length; i++) {
                hash = hashes[i].split('=');
                vars.push(hash[0]);
                vars[hash[0]] = hash[1];
            }
            return vars;
        }
    </script>

     <section id="page-title">

        <div class="container clearfix">
            <h1>My Account</h1>
            <ol class="breadcrumb">
                <li><a href="About.aspx">About</a></li>

                <li class="active">Login</li>
            </ol>
        </div>

    </section>
    <!-- #page-title end -->

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
                                    <div class="nobottommargin">
                                       
                                            <div class="fancy-title title-center title-dotted-border">
                                                <h3>Login to your Account</h3>
                                            </div>
                                            <div class="col_full">
                                                <label for="loginUsername">Username:</label>
                                                <asp:TextBox ID="LoginUserName" runat="server" tabindex="1" value="" placeholder="Username" class="sm-form-control required"></asp:TextBox>
                                            </div>

                                        <div class="col_full">
                                                <label for="loginUsername">Username:</label>
                                                <asp:TextBox ID="TextBox1" runat="server" tabindex="1" value="" placeholder="Username" class="sm-form-control required"></asp:TextBox>
                                            </div>
                                        <div class="col_full">
                                                <label for="loginUsername">Username:</label>
                                                <asp:TextBox ID="TextBox2" runat="server" tabindex="1" value="" placeholder="Username" class="sm-form-control required"></asp:TextBox>
                                            </div>
                                        <div class="col_full">
                                                <label for="loginUsername">Username:</label>
                                                <asp:TextBox ID="TextBox3" runat="server" tabindex="1" value="" placeholder="Username" class="sm-form-control required"></asp:TextBox>
                                            </div>
                                        <div class="col_full">
                                                <label for="loginUsername">Username:</label>
                                                <asp:TextBox ID="TextBox4" runat="server" tabindex="1" value="" placeholder="Username" class="sm-form-control required"></asp:TextBox>
                                            </div>
                                        <div class="col_full">
                                                <label for="loginUsername">Username:</label>
                                                <asp:TextBox ID="TextBox5" runat="server" tabindex="1" value="" placeholder="Username" class="sm-form-control required"></asp:TextBox>
                                            </div>
                                        <div class="col_full">
                                                <label for="loginUsername">Username:</label>
                                                <asp:TextBox ID="TextBox6" runat="server" tabindex="1" value="" placeholder="Username" class="sm-form-control required"></asp:TextBox>
                                            </div>
                                        <div class="col_full">
                                                <label for="loginUsername">Username:</label>
                                                <asp:TextBox ID="TextBox7" runat="server" tabindex="1" value="" placeholder="Username" class="sm-form-control required"></asp:TextBox>
                                            </div>
                                        <div class="col_full">
                                                <label for="loginUsername">Username:</label>
                                                <asp:TextBox ID="TextBox8" runat="server" tabindex="1" value="" placeholder="Username" class="sm-form-control required"></asp:TextBox>
                                            </div>
                                        <div class="col_full">
                                                <label for="loginUsername">Username:</label>
                                                <asp:TextBox ID="TextBox9" runat="server" tabindex="1" value="" placeholder="Username" class="sm-form-control required"></asp:TextBox>
                                            </div>
                                        <div class="col_full">
                                                <label for="loginUsername">Username:</label>
                                                <asp:TextBox ID="TextBox10" runat="server" tabindex="1" value="" placeholder="Username" class="sm-form-control required"></asp:TextBox>
                                            </div>
                                        <div class="col_full">
                                                <label for="loginUsername">Username:</label>
                                                <asp:TextBox ID="TextBox11" runat="server" tabindex="1" value="" placeholder="Username" class="sm-form-control required"></asp:TextBox>
                                            </div>
                                        <div class="col_full">
                                                <label for="loginUsername">Username:</label>
                                                <asp:TextBox ID="TextBox12" runat="server" tabindex="1" value="" placeholder="Username" class="sm-form-control required"></asp:TextBox>
                                            </div>
                                        <div class="col_full">
                                                <label for="loginUsername">Username:</label>
                                                <asp:TextBox ID="TextBox13" runat="server" tabindex="1" value="" placeholder="Username" class="sm-form-control required"></asp:TextBox>
                                            </div>
                                        <div class="col_full">
                                                <label for="loginUsername">Username:</label>
                                                <asp:TextBox ID="TextBox14" runat="server" tabindex="1" value="" placeholder="Username" class="sm-form-control required"></asp:TextBox>
                                            </div>
                                        <div class="col_full">
                                                <label for="loginUsername">Username:</label>
                                                <asp:TextBox ID="TextBox15" runat="server" tabindex="1" value="" placeholder="Username" class="sm-form-control required"></asp:TextBox>
                                            </div>
                                        <div class="col_full">
                                                <label for="loginUsername">Username:</label>
                                                <asp:TextBox ID="TextBox16" runat="server" tabindex="1" value="" placeholder="Username" class="sm-form-control required"></asp:TextBox>
                                            </div>

                                            <div class="col_full" id="error1" runat="server" style="color: red">
                                            </div>
                                            <div class="col_full" id="error" style="color: red">
                                            </div>


                                            <div class="col_full nobottommargin">

                                                <%--<input type="button" class="button button-3d button-circle button-large" id="loginSubmit" name="loginSubmit" value="login" onclick="" />--%>
                                               <asp:Button type="submit" class="button button-3d button-circle button-large" id="btnloginSubmit" text="login" runat="server" OnClick="btnLoginSubmit_Click" style= "background-color : #1E90FF" />
                                                <a href="About.aspx" class="button button-3d button-circle button-large button-black"  > Cancel </a>

                                                    <a href="Register.aspx" class="fright" target="_blank" style ="color : #1E90FF">Click here to register.</a>
                                            </div>
                            
                                    </div>
                                </div>
                            </div>
                        </div>


                    </div>

                </div>

            </div>

        </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Footer1" runat="server">
</asp:Content>
