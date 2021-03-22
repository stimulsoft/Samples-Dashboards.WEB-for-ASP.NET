<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Export_Dashboard_from_Code.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <br />
        <asp:Button ID="ButtonExportPdf" runat="server" Text="Export to PDF" OnClick="ButtonExportPdf_Click" />
        <asp:Button ID="ButtonExportExcel" runat="server" Text="Export to Excel" OnClick="ButtonExportExcel_Click" />
        <asp:Button ID="ButtonExportImage" runat="server" Text="Export to Image" OnClick="ButtonExportImage_Click" />
    </form>
</body>
</html>
