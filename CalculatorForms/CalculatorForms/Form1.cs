using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorForms
{
    public partial class Form1 : Form
    {
        double _x, _y;
        int _count;
        //bool _operation = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "CALCULATOR";
            Height = 500;
            Width = 400;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            _x = double.Parse(textBox1.Text);
            textBox1.Clear();
            _count = 1;
            label1.Text = _x.ToString() + "+";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            _x = double.Parse(textBox1.Text);
            textBox1.Clear();
            _count = 2;
            label1.Text = _x.ToString() + "-";
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            _x = double.Parse(textBox1.Text);
            textBox1.Clear();
            _count = 3;
            label1.Text = _x.ToString() + "*";
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            _x = double.Parse(textBox1.Text);
            textBox1.Clear();
            _count = 4;
            label1.Text = _x.ToString() + "/";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void buttonRez_Click(object sender, EventArgs e)
        {
            Calc();
            label1.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void Calc()
        {
            switch (_count)
            {
                case 1:
                    _y = _x + double.Parse(textBox1.Text);
                    textBox1.Text = _y.ToString();
                    break;
                case 2:
                    _y = _x - double.Parse(textBox1.Text);
                    textBox1.Text = _y.ToString();
                    break;
                case 3:
                    _y = _x * double.Parse(textBox1.Text);
                    textBox1.Text = _y.ToString();
                    break;
                case 4:
                    _y = _x / double.Parse(textBox1.Text);
                    textBox1.Text = _y.ToString();
                    break;

                default:
                    break;
            }
        }
    }
}
