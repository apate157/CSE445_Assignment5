<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebDownloadTryIt.aspx.cs" Inherits="TryItWebApp.WebDownloadTryIt" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Web Download Service</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Web Download Service</h2>
            <p>This service retrieves and returns the raw HTML content of any publicly accessible web page based on the provided URL.</p>
            Enter URL:<br />
            <asp:TextBox ID="txtUrl" runat="server" Width="400" /><br /><br />
            <asp:Button ID="btnDownload" runat="server" Text="Download HTML" OnClick="btnDownload_Click" /><br /><br />
            <asp:Literal ID="litResult" runat="server" Mode="Encode" />
        </div>
    </form>
</body>
</html>
