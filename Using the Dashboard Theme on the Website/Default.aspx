<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Using_the_Dashboard_Theme_on_the_Website._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <h3>Dashboards</h3>
    <a runat="server" href="~/Viewer?name=DashboardChristmas">Christmas</a>
    <br />
    <a runat="server" href="~/Viewer?name=DashboardEmergencyKPI">Emergency KPI</a>
    <br />
    <a runat="server" href="~/Viewer?name=DashboardExchangeTenders">Exchange Tenders</a>
    <br />
    <a runat="server" href="~/Viewer?name=DashboardFinancial">Financial</a>
    <br />
    <a runat="server" href="~/Viewer?name=DashboardSummary">Summary</a>

</asp:Content>
