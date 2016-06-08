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
       private string storage;
        public string input;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  make();
            textBox1.Text += "1";
        }

        private void button7_Click(object sender, EventArgs e)
        {
           // make();
            textBox1.Text += "2";
        }

        private void button6_Click(object sender, EventArgs e)
        {
           // make();
            textBox1.Text += "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
           // make();
            textBox1.Text += "4";
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // make();
            textBox1.Text += "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //make();
            textBox1.Text += "6";
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // make();
            textBox1.Text += "7";
        }

        private void button11_Click(object sender, EventArgs e)
        {
           // make();
            textBox1.Text += "8";
        }

        private void button10_Click(object sender, EventArgs e)
        {
           // make();
            textBox1.Text += "9";
        }

        private void button8_Click(object sender, EventArgs e)
        {
           // make();
            textBox1.Text += "0";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("."))
            {
                return;
            }
            textBox1.Text += ".";
           
        }

        private void button12_Click(object sender, EventArgs e)
        {
            storage = "+";
            input = textBox1.Text;
            textBox1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            storage = "-";
            input = textBox1.Text;
            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            storage = "*";
            input = textBox1.Text;
            textBox1.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            storage = "/";
            input = textBox1.Text;
            textBox1.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            equal();
        }

        private void equal()
        {
            switch (storage)
            { 
                case "+":
                    textBox1.Text = (Convert.ToInt32(input) + Convert.ToInt32(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (Convert.ToInt32(input) - Convert.ToInt32(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (Convert.ToInt32(input) * Convert.ToInt32(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (Convert.ToDouble(input) / Convert.ToDouble(textBox1.Text)).ToString();
                    break;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {

            textBox1.Text = "";
           // textBox1.Text = "0";
            textBox1.Enabled = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }
       /* private void make()
        {
            if (textBox1.Text.Substring(0, 1) == "0" )
                textBox1.Text = "";
        }*/
    }
}
