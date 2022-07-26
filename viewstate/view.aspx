<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="view.aspx.cs" Inherits="viewstate.view" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Lbl1" runat="server" Text="UserName"></asp:Label>&nbsp;&nbsp;&nbsp;
            &nbsp;
            <asp:TextBox ID="Txtuname" runat="server"></asp:TextBox>
        </div>
        <p>
        <asp:Label ID="Lbl2" runat="server" Text="Password"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Txtpswd" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <asp:Button ID="BtnStore" runat="server" Text="Store" OnClick="BtnStore_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Btnload" runat="server" Text="load" OnClick="Btnload_Click" />
        <br />
        <br />
        <asp:Label ID="Lbl3" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
