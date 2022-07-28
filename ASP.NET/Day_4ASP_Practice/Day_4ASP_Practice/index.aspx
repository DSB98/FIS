<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Day_4ASP_Practice.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            Username&nbsp; :&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Username" runat="server"></asp:TextBox>
            <br />
            <br />
            Email&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;&nbsp; <asp:TextBox ID="Email" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="BtnTrnasfer" runat="server" Text="Transfer" OnClick="BtnTrnasfer_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnTransferToServer" runat="server" Text="Transfer To Server" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnExecute" runat="server" Text="Execute" OnClick="BtnExecute_Click" />
        </div>
    </form>
</body>
</html>
