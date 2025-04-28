<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Top10TryIt.aspx.cs" Inherits="TryItWebApp.Top10TryIt" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Top 10 Content Words</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Top 10 Content Words</h2>
            <p>This service analyzes the HTML content of a webpage and returns the ten most frequently occurring non-trivial words.</p>
            Enter URL:<br />
            <asp:TextBox ID="txtUrl" runat="server" Width="400" /><br /><br />
            <asp:Button ID="btnAnalyze" runat="server" Text="Analyze" OnClick="btnAnalyze_Click" /><br /><br />
            <asp:Label ID="lblOutput" runat="server" />
        </div>
    </form>
</body>
</html>
