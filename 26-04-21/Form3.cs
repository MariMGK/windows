using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApp4
{
    public partial class Form3 : Form
    {
        private static FileStream fs = new FileStream(@"d:\Ajith.txt", FileMode.OpenOrCreate, FileAccess.Write);
        private static StreamWriter m_streamWriter = new StreamWriter(fs);
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Timer Started");
            timer1.Enabled = true;
            timer1.Tick += new System.EventHandler(OnTimerEvent);
        }
        private void OnTimerEvent(object sender,EventArgs e)
        {
            listBox1.Items.Add(DateTime.Now.ToLongTimeString() + "," + DateTime.Now);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Timer Stopped");
            timer1.Enabled = false;

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            m_streamWriter.BaseStream.Seek(0, SeekOrigin.End);
            m_streamWriter.Write("File Write Operation Starts:");

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            m_streamWriter.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongTimeString());
            m_streamWriter.Flush();
        }
    }
}
