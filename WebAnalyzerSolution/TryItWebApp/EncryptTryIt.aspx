<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EncryptTryIt.aspx.cs" Inherits="TryItWebApp.EncryptTryIt" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Encrypt / Decrypt</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Encryption Service (Caesar Cipher)</h2>
            <p>This service performs basic Caesar cipher encryption and decryption by shifting characters based on a user-defined value implemented entirely in local C# code..</p>
            Input Text:<br />
            <asp:TextBox ID="txtInput" runat="server" Width="400" /><br /><br />
            Shift Value:<br />
            <asp:TextBox ID="txtShift" runat="server" Width="100" /><br /><br />
            <asp:Button ID="btnEncrypt" runat="server" Text="Encrypt" OnClick="btnEncrypt_Click" />
            <asp:Button ID="btnDecrypt" runat="server" Text="Decrypt" OnClick="btnDecrypt_Click" /><br /><br />
            <asp:Label ID="lblResult" runat="server" />
        </div>
    </form>
</body>
</html>
