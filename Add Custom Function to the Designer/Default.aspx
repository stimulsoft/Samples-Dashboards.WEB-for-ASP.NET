<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Add_Custom_Function_to_the_Designer._Default" %>
<%@ Register assembly="Stimulsoft.Report.WebDesign" namespace="Stimulsoft.Report.Web" tagprefix="cc2" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <cc2:StiWebDesigner ID="StiWebDesigner1" runat="server"
            OnGetReport="StiWebDesigner1_GetReport" />

</asp:Content>
