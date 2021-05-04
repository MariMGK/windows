using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Text = "Welcome";
            Text1.Value = "hello";
            Random r = new Random();
            int nu= r.Next();
            Label1.Text = r.Next(1, 11).ToString();

        }
    }
}