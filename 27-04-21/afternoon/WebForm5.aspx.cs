using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                CheckBoxList1.Items.Add("Pizza");
                CheckBoxList1.Items.Add("Hamburgers");
                CheckBoxList1.Items.Add("Pasta");


            }

        }

        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                Response.Write(CheckBoxList1.SelectedValue.ToString());
            string strlist = string.Empty;
            foreach(ListItem itmfood in CheckBoxList1.Items)
            {
                if (itmfood.Selected)
                    strlist += "<li> "+ itmfood.Text;
                Label1.Text = strlist;
            }

            

        }
    }
}