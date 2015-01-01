using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch3
{
    public partial class Form1 : Form
    {
        TimeSpan StartTime = new TimeSpan(0, 0, 0);
        TimeSpan addTime = new TimeSpan(0, 0, 1);
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            StartTime = StartTime + addTime;
            label1.Text = StartTime.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled =! timer1.Enabled;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            StartTime = new TimeSpan(0, 0, 0);
            label1.Text = StartTime.ToString();
            label2.Text = ("Lap 1");
            label3.Text = ("Lap 2");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = StartTime.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Text = StartTime.ToString();
        }

    }
}
