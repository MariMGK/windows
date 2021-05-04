using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text += "page load event";
            Response.Write("page load event <br>");
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            Label1.Text += "page Init event\n";
            Response.Write("page Init event <br>");
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            Label1.Text += "page Render event";
            Response.Write("page Render event <br>");
        }
    }
}