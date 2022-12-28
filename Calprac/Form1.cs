using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calprac
{
    public partial class Form1 : Form
    {
        int num1, num2;
        int result;
        string op; 

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text += "1";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(textBox2.Text);
            op = "+";
            textBox1.Text += textBox2.Text + "+";
            textBox2.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text += "5";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox2.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox2.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox2.Text += "9";
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(textBox2.Text);
            if(op == "+")
            {
                result = num1 + num2;
            }

            textBox2.Text = Convert.ToString(result);
        }
    }
}
