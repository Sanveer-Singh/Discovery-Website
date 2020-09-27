<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AdvisorDashBoard.aspx.cs" Inherits="IRateAdvisorWeb.AdvisorDashBoard" Async ="false" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="content-wrap">
        <div class="heading-block center">
			<h2> Spend data analysed by<span style="color:#1E90FF;"> I_Rate_Advisor </span>: </h2>
				<span>(Spending is catagorized by 16 different spending types.)</span>

        </div>
        <div class="heading-block center">
         <asp:Chart ID="Chart1" runat="server" Height="500" Width="500">
           <Series>
		<asp:Series Name="Testing" YValueType="Int32">

			<Points>
				<asp:DataPoint AxisLabel="Test 1" YValues="10" />
				<asp:DataPoint AxisLabel="Test 2" YValues="20" />

				<asp:DataPoint AxisLabel="Test 3" YValues="30" />
				<asp:DataPoint AxisLabel="Test 4" YValues="40" />

			</Points>
		</asp:Series>
	</Series>
	<ChartAreas>
		<asp:ChartArea Name="ChartArea1">
		</asp:ChartArea>

	</ChartAreas>
        </asp:Chart>
          </div>
            <div class="heading-block center">
			<h2> Your current tier is :<span style="color:#1E90FF;" runat ="server" ID="Tier">  </span>.</h2>
				<span>(Tiers are ranked from blue to gold.)</span>
                <h2> Your next tier is :<span style="color:#1E90FF;" runat ="server" ID="TierAbove"> </span>. </h2>
             </div>
         <div class="heading-block center">
			<h2> Your currrent goal is :<span style="color:#1E90FF;" runat ="server" ID="MyGoal"> Goal </span>. </h2>
				<span>Your custom goal will be rewarded with:</span>
                <h2> Reward:<span style="color:#1E90FF;" runat ="server" ID="MyReward"> MyReward</span>. </h2>
             </div>
        
    </div>
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Footer1" runat="server">
</asp:Content>
