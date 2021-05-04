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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        static void  Increament(int i)
        {
            i = i + 1;
        }
        static void Increament(ref int i)
        {
            i = i + 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 1;
            Increament(x);
            MessageBox.Show("the value is:" + x);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = 1;
            Increament(ref x);
            MessageBox.Show("the ref is:" + x);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Class1 c = new Class1();
            int m = c.method();
            MessageBox.Show(m.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Class1 c = new Class1();
            int m = c.staticmethod();
            MessageBox.Show(m.ToString());

        }
        int a3 = 1;
        private void button5_Click(object sender, EventArgs e)
        {
            int w = globalmethod();
            MessageBox.Show(w.ToString());

        }
        public int globalmethod()
        {
            a3 = a3 + 1;
            return a3;
        }
        int i;
        object obj;


        private void button6_Click(object sender, EventArgs e)
        {
            int input = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter No", "Test Warp", "0"));
            i = input;
            MessageBox.Show("int:" + i.ToString());
            obj = i;
            MessageBox.Show("Object:" + obj.ToString());
            i = (int)obj;
            MessageBox.Show("Converted:" + i.ToString());

        }
    }
}
