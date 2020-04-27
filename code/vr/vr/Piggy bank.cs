using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double test = Convert.ToDouble(textBox2.Text);
            double testik = Convert.ToDouble(textBox1.Text);
            var procent = testik / test * 100; 
            label1.Text = procent + " %";
            int pb = Convert.ToInt32(procent);
            progressBar1.Value = pb;
            int test2 = Convert.ToInt32(textBox2.Text);
            int testik2 = Convert.ToInt32(textBox1.Text);
            int day = Convert.ToInt32(textBox3.Text);
            int dayon = day / 30;
            int tester = (test2 - testik2) / dayon;
            int months = tester / 31;
            int hours = tester * 24;
            int minutes = hours * 60;
            int seconds = minutes * 60;
            label2.Text = "Осталось примерно - " + seconds + " секунд или - "+ minutes + " минут или - " + hours + " часов или - " + tester + " дней или - " + months + " месяцев(месяц)";
            if (progressBar1.Value >= 100)
            {
                label3.Visible = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
