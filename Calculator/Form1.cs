using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("0");
        }

        private void bt1_Click(object sender, EventArgs e)
        { 
            textBox1.AppendText("1");
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("2");
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("3");
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("4");
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("5");
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("6");
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("7");
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("8");
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            lb1.te
        }
    }
}
