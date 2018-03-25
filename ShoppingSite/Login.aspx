<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="User Name : "></asp:Label>
        <asp:TextBox ID="UserName" runat="server" Height="18px"></asp:TextBox>
        <p>
            <asp:Button ID="Log" runat="server" OnClick="Log_Click" Text="Login" />
        </p>
    </form>
</body>
</html>
