using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Label1.Text = e.X.ToString();
            Label2.Text = e.Y.ToString();
            if(e.X==106)
            {
                if(e.Y==124)
                {
                    Label3.Text = "!!!you win";
                }
            }
            else
            {
                Label3.Text = "you missed";
            }


        }
    }
}