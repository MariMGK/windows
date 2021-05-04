using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RangeValidator1.MinimumValue = DateTime.Now.ToString("dd/MM/yyyy");
            RangeValidator1.MaximumValue = DateTime.Now.AddMonths(3).ToString("dd/MM/yyyy");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(Page.IsValid)
            {
                Response.Redirect("WebForm2.aspx");
            }
        }
    }
}