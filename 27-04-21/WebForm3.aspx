<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication2.WebForm3" %>

<!DOCTYPE html>
<script runat="server">
    string strsometext;
    void Page_Load(object sender, EventArgs e)
    {
        strsometext = "hello";
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%Response.Write("The Value of strsometext is:" + "<br>"); %>
            <%=strsometext %>

            <p>
                 <%strsometext = "goodbye"; %>
                <%Response.Write("The Value of strsometext is:" + "<br>"); %>
            <%=strsometext %>

            </p>
        </div>
    </form>
</body>
</html>
