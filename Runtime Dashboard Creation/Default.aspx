<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Runtime_Dashboard_Creation.Default" %>
<%@ Register assembly="Stimulsoft.Report.Web" namespace="Stimulsoft.Report.Web" tagprefix="cc1" %>
<%@ Register assembly="Stimulsoft.Report.WebDesign" namespace="Stimulsoft.Report.Web" tagprefix="cc2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <br />
        <asp:Button ID="ButtonShow" runat="server" Text="Show Dashboard" OnClick="ButtonShow_Click" />
        <asp:Button ID="ButtonEdit" runat="server" Text="Edit Dashboard" OnClick="ButtonEdit_Click" />
        <asp:Button ID="ButtonExport" runat="server" Text="Export To Excel" OnClick="ButtonExport_Click" />
    
        <cc1:StiWebViewer ID="StiWebViewer1" runat="server" FullScreenMode="true" Visible="false" />
        <cc2:StiWebDesigner ID="StiWebDesigner1" runat="server" Visible="false" />
    </form>
</body>
</html>
