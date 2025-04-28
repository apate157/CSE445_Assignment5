<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TryItWebApp.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Web Services Application - Assignment 5</title>
    <style>
        body { font-family: Arial; padding: 20px; }
        h2 { color: darkblue; }
        table, th, td { border: 1px solid #ccc; border-collapse: collapse; padding: 8px; }
        th { background-color: #f4f4f4; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Welcome to the AI-Powered Web Services Portal</h2>
        <p>This application demonstrates a set of web services, including AI-based conflict resolution, content analysis, and data security.</p>

         <asp:HyperLink 
+            ID="lnkLogin" 
+            runat="server" 
+            NavigateUrl="Login.aspx"
+            Text="Log In" 
+            CssClass="login-link" />
+        <br /><br />

        <h3>Service Directory</h3>
        <asp:Table ID="tblServices" runat="server" BorderWidth="1" GridLines="Both" />

        <br /><br />
        <asp:Button ID="btnGoToArgument" runat="server" Text="Try Argument Resolver" OnClick="btnGoToArgument_Click" />
        <asp:Button ID="btnGoToEncrypt" runat="server" Text="Try Encryption" OnClick="btnGoToEncrypt_Click" />
        <asp:Button ID="btnGoToTopWords" runat="server" Text="Try Top Words" OnClick="btnGoToTopWords_Click" />
        <asp:Button ID="btnGoToDownload" runat="server" Text="Try Web Download" OnClick="btnGoToDownload_Click" />
        <asp:Button ID="btnGoToPassword" runat="server" Text="Try Password Strength" OnClick="btnGoToPassword_Click" />
        <br /><br />
        <asp:Label ID="lblSessionInfo" runat="server" ForeColor="Gray" />
    </form>
</body>
</html>
