<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Export_Dashboard_from_Code._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />

    <asp:Button ID="ButtonExportPdf" runat="server" Text="Export to PDF" OnClick="ButtonExportPdf_Click" />
    <asp:Button ID="ButtonExportExcel" runat="server" Text="Export to Excel" OnClick="ButtonExportExcel_Click" />
    <asp:Button ID="ButtonExportImage" runat="server" Text="Export to Image" OnClick="ButtonExportImage_Click" />

</asp:Content>
