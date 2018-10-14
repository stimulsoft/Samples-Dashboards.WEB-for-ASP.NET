<%@ Page Title="Edit Dashboard in the Designer" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Edit_Dashboard_in_the_Designer._Default" %>
<%@ Register assembly="Stimulsoft.Report.WebDesign" namespace="Stimulsoft.Report.Web" tagprefix="cc2" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    
    <cc2:StiWebDesigner ID="StiWebDesigner1" runat="server"
            OnGetReport="StiWebDesigner1_GetReport" />

</asp:Content>
