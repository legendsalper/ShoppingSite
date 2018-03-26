<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductInfo.aspx.cs" Inherits="ProductInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 180px;
        }
        #cor {
            height: 41px;
        }
    </style>
</head>
<body style="height: 97px">
    <form id="form1" runat="server">
        <div id="cor">
            <asp:Label ID="productname" runat="server"></asp:Label>
        <asp:Label ID="Label1" runat="server" Text="Type:"></asp:Label>
        <asp:Label ID="type" runat="server"></asp:Label>
        <asp:Label ID="Label2" runat="server" Text="Vendor:"></asp:Label>
        <asp:Label ID="Vendor" runat="server"></asp:Label>
        <asp:Button ID="cartt" runat="server" Text="Add to Cart" OnClick="cartt_Click" />
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Display Shopping Cart</asp:LinkButton>
        <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">Return To Main Page</asp:LinkButton>
            <asp:Image ID="imgg" runat="server" />
        </div>
        <br />
        <br />
        <div id="err1">
            <asp:Label ID="err" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
