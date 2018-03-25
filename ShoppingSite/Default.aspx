<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #seconddiv {
            height: 351px;
            width: 1308px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="firstdiv" runat="server">
            <asp:Label ID="Label1" runat="server" Text="You are not logged in"></asp:Label>
            <p>
            <asp:Label ID="Label2" runat="server" Text="Please log in "></asp:Label>
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="here">here</asp:LinkButton>
            </p>
        </div>
        
        <div id="seconddiv" runat="server">
                               
            
        
            <table>
                <tr>
    <td></td>
    <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Click on a link below:</td>
  </tr>
  <tr>
    <td></td>
    <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:LinkButton ID="c270" runat="server" OnClick="c270_Click">Samsung C270</asp:LinkButton></td>
  </tr>
  <tr>
    <td><asp:Label ID="Label3" runat="server" Text="Welcome - "></asp:Label>
            <asp:Label ID="nameniz" runat="server"></asp:Label></td>
    <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:LinkButton ID="e250i" runat="server" OnClick="e250i_Click">Samsung E250i</asp:LinkButton></td>
  </tr>
  <tr>
    <td><asp:LinkButton ID="showcart" runat="server" OnClick="showcart_Click">Display Shopping Cart</asp:LinkButton></td>
    <td> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:LinkButton ID="l500" runat="server" OnClick="l500_Click">Toshiba L500</asp:LinkButton></td>
  </tr>
  <tr>
    <td><asp:Button ID="logout" runat="server" Height="26px" Text="Logout" Width="57px" OnClick="logout_Click" /></td>
    <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:LinkButton ID="g550" runat="server" OnClick="g550_Click">Lenovo G550</asp:LinkButton></td>
  </tr>
  <tr>
    <td></td>
    <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:LinkButton ID="fo200" runat="server" OnClick="fo200_Click">Acer FO200</asp:LinkButton></td>
  </tr>
</table>


        </div>
        
    </form>
</body>
</html>
