using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private double CalculateArea (double length, double width)
        {
            return length * width;
        }
        private double CalculateArea (double radius)
        {
            return radius * radius * Math.PI;
        }
        private double CalculatArea (double baseLength, double height)
        {
            return baseLength * height * 0.5;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double length = Convert.ToDouble(textBox1.Text);
            double width = Convert.ToDouble(textBox2.Text);
            double area = CalculateArea( length, width);
            textBox6.Text =("Rectangle: " + area.ToString());
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double radius = Convert.ToDouble(textBox3.Text);
            double area = CalculateArea(radius);
            textBox6.Text = ("Circle: " + area.ToString());
            textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double height = Convert.ToDouble(textBox4.Text);
            double baseLength = Convert.ToDouble(textBox5.Text);
            double area = CalculatArea(baseLength, height);
            textBox6.Text = ("Triangle: " + area.ToString());
            textBox4.Clear();
            textBox5.Clear();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox6.Text);
        }
    }
}
