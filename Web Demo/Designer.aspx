<%@ Page Title="Edit Dashboard" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Designer.aspx.cs" Inherits="Web_Demo.Designer" %>
<%@ Register assembly="Stimulsoft.Report.WebDesign" namespace="Stimulsoft.Report.Web" tagprefix="cc2" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <cc2:StiWebDesigner ID="StiWebDesigner1" runat="server"
            OnGetReport="StiWebDesigner1_GetReport" />

</asp:Content>
