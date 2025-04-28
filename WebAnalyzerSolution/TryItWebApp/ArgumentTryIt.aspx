<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ArgumentTryIt.aspx.cs" Inherits="TryItWebApp.ArgumentTryIt" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>AI Argument Resolver</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>AI Argument Resolver</h2>
        <p>This service uses Google Gemini AI to suggest respectful resolutions for everyday conflicts based on your input.</p>
        Enter Argument:<br />
        <asp:TextBox ID="txtArgument" runat="server" Width="500" Height="80" TextMode="MultiLine" /><br /><br />
        <asp:Button ID="btnResolve" runat="server" Text="Resolve" OnClick="btnResolve_Click" /><br /><br />
        <asp:Label ID="lblResponse" runat="server" />
    </form>
</body>
</html>
