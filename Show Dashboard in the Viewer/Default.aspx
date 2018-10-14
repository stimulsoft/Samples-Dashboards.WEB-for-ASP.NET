<%@ Page Title="Show Dashboard in the Viewer" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Show_Dashboard_in_the_Viewer._Default" %>
<%@ Register assembly="Stimulsoft.Report.Web" namespace="Stimulsoft.Report.Web" tagprefix="cc1" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />

    <cc1:StiWebViewer ID="StiWebViewer1" runat="server"
            OnGetReport="StiWebViewer1_GetReport" />

</asp:Content>
