<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication1.WebForm2" %>


<script runat="server">
    void Button_Command(Object sender, CommandEventArgs e)
    {

        int intAmount;

        intAmount = System.Convert.ToInt32(e.CommandArgument);
        if (e.CommandName == "Add")
        {
            int myValueAdd = System.Convert.ToInt32(Label1.Text) + (intAmount);
            Label1.Text = myValueAdd.ToString();
        }
        else
        {
            int myValueSubtract = System.Convert.ToInt32(Label1.Text) - (intAmount);
            Label1.Text = myValueSubtract.ToString();
        }
    }
</script>
<!DOCTYPE html>
<html  xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" CommandName="Add" CommandArgument="5" OnCommand="Button_Command" runat="server" Text="ADD" />

            <asp:Button ID="Button2" CommandName="Subtract" CommandArgument="10" OnCommand="Button_Command" runat="server" Text="SUBTRACT" />
            <asp:Label ID="Label1" runat="server" Text="0"></asp:Label>

        </div>
    </form>
</body>
</html>
