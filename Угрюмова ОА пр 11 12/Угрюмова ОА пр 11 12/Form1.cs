using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Угрюмова_ОА_пр_11_12
{
    public partial class Student_work : Form
    {
        public Student_work()
        {
            InitializeComponent();
        }
        private void Student_work_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Student stud = new Student();
            stud.name = textBox1.Text;
            stud.rost = (int)numericUpDown1.Value;
            stud.ves = double.Parse(textBox2.Text);
            stud.eda = double.Parse(textBox3.Text);
            MessageBox.Show(string.Format("Студент: {0} \nрост: {1} \nвес: {2}", stud.name, stud.SetRost(stud.eda,stud.rost), stud.SetEat(stud.eda, stud.GetEat())));
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
