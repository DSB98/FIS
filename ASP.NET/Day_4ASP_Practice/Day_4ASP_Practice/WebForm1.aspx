<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Day_4ASP_Practice.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyContentPlaceHolder" runat="server">
    <form id="form1" runat="server">
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        <br />
&nbsp;<br />
&nbsp;&nbsp;&nbsp;
        <asp:FileUpload ID="FileToUpload" runat="server" />
        <br />
        <asp:Label ID="Msg" runat="server" Text=""></asp:Label>
        <br />
        <div style="margin-left: 80px">
            <asp:Button ID="BtnUpload" runat="server" Text="Upload File" Width="117px" OnClick="BtnUpload_Click" />
        </div>
    </form>
</asp:Content>
