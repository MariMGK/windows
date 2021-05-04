using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp4
{
    
    public partial class Form5 : Form
    {
        SqlConnection connection;
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int empID, posID;
            string empName, postionName;
            try
            {
                connection = new SqlConnection("Data Source=LAPTOP-E0NVL0L7\\SQLEXPRESS;Initial Catalog=Craftsman;Integrated Security=True");
                string spname = @"employeejoin";
                SqlCommand cmd = new SqlCommand(spname, connection);
                SqlParameter pa1 = new SqlParameter();
                pa1.ParameterName = "@empid";
                pa1.SqlDbType = SqlDbType.Int;
                pa1.Value = int.Parse(textBox1.Text);
                cmd.Parameters.Add(pa1);
                connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        empID = dr.GetInt32(0);
                        empName = dr.GetString(1);
                        posID = dr.GetInt32(2);
                        postionName = dr.GetString(3);
                        MessageBox.Show(empID.ToString() + "\n" + empName + "\n" + posID + "\n" + postionName);
                    }
                }
                else
                {
                    MessageBox.Show("No data found");

                }
                dr.Close();
                connection.Close();

                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Exception:" + ex.Message);
            }


        }
    }
}
