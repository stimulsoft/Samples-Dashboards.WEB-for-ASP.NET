<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Runtime_Dashboard_Creation._Default" %>
<%@ Register assembly="Stimulsoft.Report.Web" namespace="Stimulsoft.Report.Web" tagprefix="cc1" %>
<%@ Register assembly="Stimulsoft.Report.WebDesign" namespace="Stimulsoft.Report.Web" tagprefix="cc2" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <asp:Button ID="ButtonShow" runat="server" Text="Show Dashboard" OnClick="ButtonShow_Click" />
    <asp:Button ID="ButtonEdit" runat="server" Text="Edit Dashboard" OnClick="ButtonEdit_Click" />
    
    <cc1:StiWebViewer ID="StiWebViewer1" runat="server" Visible="false" />
    <cc2:StiWebDesigner ID="StiWebDesigner1" runat="server" Visible="false" />
</asp:Content>
