using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(CheckBoxbold.Checked)
            {
                Labelmessage.Font.Bold = true;
            }
            else
            {
                Labelmessage.Font.Bold = false;

            }
            if (CheckBoxitalic.Checked)
            {
                Labelmessage.Font.Italic= true;
            }
            else
            {
                Labelmessage.Font.Italic= false;

            }
        }
    }
}