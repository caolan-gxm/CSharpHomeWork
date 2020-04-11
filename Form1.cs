using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (graphics == null) graphics = this.CreateGraphics();
            drawCayleyTree(num, 200, 310, length, -Math.PI / 2);
        }
        private Graphics graphics;
        double th1;
        double th2;
        double length;
        int num;
        double per1;
        double per2;
        Pen p;
            
        void drawCayleyTree(int n, double x0, double y0, double leng, double th)   
        {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            drawLine(x0, y0, x1, y1);
            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }         
        void drawLine(double x0, double y0, double x1, double y1)
        {
            graphics.DrawLine(p, (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            num= Convert.ToInt32(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            length = Convert.ToDouble(textBox2.Text);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            per1 = Convert.ToDouble(textBox3.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            per2 = Convert.ToDouble(textBox4.Text);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            th1=Convert.ToDouble(textBox5.Text)  * Math.PI / 180;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            th2=Convert.ToDouble(textBox6.Text)  * Math.PI / 180;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog { AllowFullOpen = false, ShowHelp = false };
            if (colorDialog.ShowDialog() != DialogResult.OK) return;

            label8.BackColor = colorDialog.Color;
            p = new Pen(colorDialog.Color);
        }
    }
    }