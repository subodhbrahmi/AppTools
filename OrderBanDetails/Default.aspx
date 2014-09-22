<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        RETRIEVE DETAILS<br />
        <br />
    
    </div>
        <asp:Label ID="Label1" runat="server" Text="Input Data"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" Height="16px">
            <asp:ListItem>BAN</asp:ListItem>
            <asp:ListItem Value="Order">Order Numer</asp:ListItem>
        </asp:DropDownList>
        <p>
            <asp:Label ID="Label3" runat="server" Text="&lt;path&gt;"></asp:Label>
            <asp:FileUpload ID="FileUpload1" runat="server" />
        </p>
        <asp:Button ID="Button1" runat="server" Text="Submit" />
    </form>
</body>
</html>
