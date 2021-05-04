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
    public partial class Form6 : Form
    {

        Student[] studentArray =
        {
            new Student() {StudentID=1,Studentname="John",Age=18},
        new Student() { StudentID = 2,Studentname = "Steve",Age = 19},
            new Student() {StudentID=3,Studentname="Bill",Age=20},
            new Student() {StudentID=4,Studentname="Ram",Age=21},
            new Student() {StudentID=5,Studentname="Ron",Age=22},
            new Student() {StudentID=6,Studentname="Chris",Age=23},
            new Student() {StudentID=7,Studentname="Ajith",Age=24},
            new Student() {StudentID=8,Studentname="Bala",Age=25},
            new Student() {StudentID=9,Studentname="Amal",Age=26}
        };




        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student[] students = new Student[10];
                int i = 0;
            foreach(Student std in studentArray)
            {
                if(std.Age >12 && std.Age<20)
                {
                    students[i] = std;
                    i++;
                    MessageBox.Show(std.Studentname);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] names = { "Bill", "Steve", "James", "Kim","john" };
            var query = from name in names where name.Contains('J')|| name.Contains('e') select name;
            foreach(var name in query)
            {
                MessageBox.Show(name + "");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i;
            Student[] teenAgerstudents = studentArray.Where(s => s.Age > 12 && s.Age < 20).ToArray();
            for(i=0;i<teenAgerstudents.Length;i++)
            {
                MessageBox.Show(teenAgerstudents[i].Studentname);
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Student bill = studentArray.Where(s => s.Studentname == "Bill").FirstOrDefault();
            MessageBox.Show(bill.Age.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Student a = studentArray.Where(s => s.StudentID == 2).FirstOrDefault();
            MessageBox.Show(a.Age.ToString());

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Student[] students = studentextend.where(studentArray, delegate (Student std)
              {
                  return std.Age > 12 && std.Age < 20;
              });
            int i;
            for(i=0;i<students.Length;i++)
            {
                MessageBox.Show(students[i].Studentname);
            }
        }
    }
}
