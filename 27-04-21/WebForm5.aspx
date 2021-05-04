<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="WebApplication2.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>







        
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
   
        <textarea id="TextArea1" runat="server" cols="20" name="S1" rows="2"></textarea>
        
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
       <span id="s1" runat="server"></span>
            </div>
    </form>
    </body>
</html>
