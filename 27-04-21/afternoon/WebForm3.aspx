<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication1.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:CheckBox ID="CheckBox1" Text="Do You Like This Website?" runat="server" />

        </div>
        <p>
            <asp:Button ID="Button1" Text="Submit Answer" OnClick="Button_Click" runat="server"  />
            </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

        </p>
    </form>
</body>
</html>
