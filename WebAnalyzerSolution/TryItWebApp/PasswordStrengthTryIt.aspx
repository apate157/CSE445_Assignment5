<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PasswordStrengthTryIt.aspx.cs" Inherits="TryItWebApp.PasswordStrengthTryIt" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Password Strength Evaluator</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Password Strength Evaluator</h2>
        <p style="color:gray;">Password scoring rules are implemented in the local code-behind using .NET methods for character analysis.</p>
        <p>This service analyzes your password and returns a strength rating along with suggestions for improvement based on common security criteria.</p>
        Enter Password:<br />
        <asp:TextBox ID="txtPassword" runat="server" Width="300" TextMode="Password" /><br /><br />
        <asp:Button ID="btnCheck" runat="server" Text="Check Strength" OnClick="btnCheck_Click" /><br /><br />
        <asp:Label ID="lblResult" runat="server" />
    </form>
</body>
</html>
