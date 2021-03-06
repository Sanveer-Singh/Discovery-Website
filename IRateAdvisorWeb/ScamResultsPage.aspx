﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ScamResultsPage.aspx.cs" Inherits="IRateAdvisorWeb.ScamResultsPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
		     <script src="js/jquery.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $('#iView').on("click touch", function () {
                var pass = $("#Password1");
                if (pass.attr("type") == "text") {
                    var eye = $(this);
                    eye.attr("class", "i-circled icon-eye-close");
                    pass.attr({ 'type': 'password' });
                } else {
                    var eye = $(this);
                    eye.attr("class", "i-circled icon-eye-open");
                    pass.attr("type", "text");
                }
            });
            $("#loginSubmit").on("click touch", function () {
                $("#error").text("");
                var username = $("#loginUsername").val();
                var pass = $("#Password1").val();
                if (username.length == 0) {
                    $("#error").text("Please fill in your username");
                    return;
                } else if (pass.length == 0) {
                    $("#error").text("Please fill in your password");
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
                                                <h3>Scam Questionnaire Results</h3>
                                            </div>
                                            <div class="col_full">
                                                <label id="informationLabel" runat="server"></label>
                                            </div>

<%--                                            <div class="col_full">
                                                <label for="loginPassword">Password:</label>
                                                <input type="password" id="Password1" name="loginPassword" tabindex="2" value="" class="sm-form-control required" placeholder="Password" runat="server"/>
                                                <!-- the visibility switch-->
                                            <br/>--%>
                                            </div>

                                            <div class="col_full" id="error1" runat="server" style="color: red">
                                            </div>
                                            <div class="col_full" id="error" style="color: red">
                                            </div>


                                            <div class="col_full nobottommargin">

                                                <%--<input type="button" class="button button-3d button-circle button-large" id="loginSubmit" name="loginSubmit" value="login" onclick="" />--%>
                                               <%--<asp:Button type="submit" class="button button-3d button-circle button-large" id="btnloginSubmit" text="login" runat="server" OnClick="btnLoginSubmit_Click" style= "background-color : #1E90FF" />--%>
                                                <a href="About.aspx" class="button button-3d button-circle button-large button-black"  > Return Home </a>

<%--                                                    <a href="Register.aspx" class="fright" target="_blank" style ="color : #1E90FF">Click here to register.</a>--%>
                                            </div>
                            
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
