<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ThemeForm.aspx.cs" Inherits="Day_4ASP_Practice.ThemeForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Username" BackColor="#E8FFFB" BorderColor="#003366" BorderStyle="Ridge"></asp:Label>
&nbsp; :&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
           
            <br />
            <br />
           
            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
&nbsp; :&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
          
            <br />
            <br />
          
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Login" />
        </div>
    </form>
</body>
</html>
