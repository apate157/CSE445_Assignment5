<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="Login.aspx.cs" Inherits="TryItWebApp.Login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Please log in</h2>
        <asp:Label ID="lblError" runat="server" ForeColor="Red" />
        <div>
            Username:<br />
            <asp:TextBox ID="txtUsername" runat="server" /><br />
            Password:<br />
            <asp:TextBox ID="txtPassword" runat="server"
                         TextMode="Password" /><br /><br />
            <asp:Button ID="btnLogin" runat="server" Text="Log In"
                        OnClick="btnLogin_Click" />
        </div>
    </form>
</body>
</html>
