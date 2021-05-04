<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="WebApplication1.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        
        <asp:CheckBoxList ID="CheckBoxList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged">
       <asp:ListItem Text="Cake" Selected="True"></asp:ListItem>
            </asp:CheckBoxList>
   
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </div>
         </form>
</body>
</html>
