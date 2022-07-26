<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QueryDest.aspx.cs" Inherits="viewstate.QueryDest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lb1" runat="Server" Text="" /><br />
             <asp:Label ID="lbl2" runat="Server" Text="" /><br />
             <asp:Button ID="BtnReceive" runat="Server" Text="Receive " OnClick="BtnReceive_Click" /><br />
        </div>
    </form>
</body>
</html>
