using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form7 : Form
    {
        public delegate void Mydelegate(string var);
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
        public void GetData1( string name)
        {
            textBox1.Text = name;
        }
        public void GetData2(string name)
        {
            textBox2.Text = name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mydelegate obj = new Mydelegate(GetData1);
            obj("peter");
        }
    }
}
