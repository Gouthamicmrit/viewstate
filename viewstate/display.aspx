

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="display.aspx.cs" Inherits="viewstate.display" %>

<!DOCTYPE html>



<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>

<br />
<br />
<asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Btnsubmit2" runat="server" Text="show" OnClick="Btnsubmit2_Click1" />
            <br />
<br />
<br />
&nbsp;<asp:Button ID="Btnlast" runat="server" Text="logout" OnClick="Btnlast_Click" />
            <br />
<br />
<br />
        </div>
    </form>
</body>
</html>
