<%@ Page Title="" Language="C#" Async="true" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Forum.aspx.cs" Inherits="IRateAdvisorWeb.Forum" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <div class="content-wrap">
            <div class="heading-block center">
			<h2> Please type a threat name to search for on<span style="color:#1E90FF;"> I_Rate_Advisor </span>: </h2>
				<span>(search is case sensitive.)</span>
                    <asp:TextBox ID="searchBox" runat="server" class="sm-form-control" Text="Search..."></asp:TextBox>
                     <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click"/>
            </div>
         </div>
      <div class="heading-block center">
           <div id="displayDiv" runat="server" >

            </div>
         </div>

   

    <asp:Label ID="error" runat="server" Text=""></asp:Label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Footer1" runat="server">
</asp:Content>
