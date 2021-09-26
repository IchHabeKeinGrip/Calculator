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

        private void btPlus_Click(object sender, EventArgs e)
        {
            if(Operant1.Text != null && Operant2.Text != null)
            {
                try
                {
                    int wert1 = Convert.ToInt32(Operant1.Text);
                    int wert2 = Convert.ToInt32(Operant2.Text);
                    int result = wert1 + wert2;
                    MessageBox.Show(result.ToString());
                }
                catch(FormatException exception)
                {
                    MessageBox.Show("Bitte gebe keine Buchstaben ein!");
                }
            } else
            {
                MessageBox.Show("Please enter a valid Number" +
                    "!");
            }
        }

        private void btMinus_Click(object sender, EventArgs e)
        {
            if (Operant1.Text != null && Operant2.Text != null)
            {
                try
                {
                    int wert1 = Convert.ToInt32(Operant1.Text);
                    int wert2 = Convert.ToInt32(Operant2.Text);
                    int result = wert1 - wert2;
                    MessageBox.Show(result.ToString());
                }
                catch(FormatException exception)
                {
                    MessageBox.Show("Bitte gebe keine Buchstaben ein!");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Number" +
                    "!");
            }
        }

        private void btMal_Click(object sender, EventArgs e)
        {
            if (Operant1.Text != null && Operant2.Text != null)
            {
                try
                {
                    int wert1 = Convert.ToInt32(Operant1.Text);
                    int wert2 = Convert.ToInt32(Operant2.Text);
                    int result = wert1 * wert2;
                    MessageBox.Show(result.ToString());
                }
                catch(FormatException exception)
                {
                    MessageBox.Show("Bitte gebe keine Buchstaben ein!");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Number" +
                    "!");
            }
        }

        private void btGeteilt_Click(object sender, EventArgs e)
        {
            if (Operant1.Text != null && Operant2.Text != null)
            {
                try
                {
                    try
                    {
                        int wert1 = Convert.ToInt32(Operant1.Text);
                        int wert2 = Convert.ToInt32(Operant2.Text);
                        int result = wert1 / wert2;
                        MessageBox.Show(result.ToString());
                    }
                    catch (DivideByZeroException exception)
                    {
                        MessageBox.Show("Teilen durch 0 nicht möglich!");
                    }
                }
                catch(FormatException exception)
                {
                    MessageBox.Show("Bitte gebe keine Buchstaben ein!");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Number" +
                    "!");
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
