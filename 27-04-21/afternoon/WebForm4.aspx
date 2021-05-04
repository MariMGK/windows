<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="WebApplication1.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:CheckBox ID="CheckBoxbold"  runat="server" Text="Bold" AutoPostBack="True" />
            <asp:CheckBox ID="CheckBoxitalic" runat="server" Text="Italic" AutoPostBack="True" />



        </div>
        <p>
            <asp:Label ID="Labelmessage" runat="server" Text="When in the course of human events it becomes..."></asp:Label>



        </p>
    </form>
</body>
</html>
