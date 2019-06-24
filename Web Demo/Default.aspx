<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Web_Demo._Default" %>
<%@ Register assembly="Stimulsoft.Report.Web" namespace="Stimulsoft.Report.Web" tagprefix="cc1" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <cc1:StiWebViewer ID="StiWebViewer1" runat="server" 
        BackgroundColor="#e8e8e8" ScrollbarsMode="true" ToolbarDisplayMode="Separated" ShowDesignButton="true"
        Width="100%" Height="100%"
        OnDesignReport="StiWebViewer1_DesignReport" />

</asp:Content>
