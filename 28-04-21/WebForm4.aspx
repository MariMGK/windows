<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="WebApplication3.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="TextBox1" runat="server" Columns="8" Width="153px" ></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox1" Text="end date must be greater than start date" ControlToValidate="TextBox2" Display="Dynamic" ErrorMessage="CompareValidator" Operator="GreaterThan" Type="Date"></asp:CompareValidator>
        <p>
            <asp:TextBox ID="TextBox2" runat="server" Columns="8" Height="16px" ></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </p>
    </form>
</body>
</html>
