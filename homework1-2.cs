using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            switch (button2.Text)               
            {
                case "+":
                    label2.Text = $"{a + b}";
                    break;
                case "-":
                    label2.Text = $"{a - b}";
                    break;
                case "*":
                    label2.Text = $"{a * b}";
                    break;
                case "/":
                    label2.Text = b == 0 ? "Can't divide by zero." : $"{a / b}";
                    break;
                default:
                    break;  
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.Text = "+";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button2.Text = "-";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button2.Text = "*";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button2.Text = "/";
        }
    }
}