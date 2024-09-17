using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mathsharp
{
    public partial class Form1 : Form
    { 
        char[] operators = { '+', '-', '*', '/' };

        private bool textboxContainsResult = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void plus_Click(object sender, EventArgs e)
        {
            checkTextBoxMode();
            if (checkLastFieldForOperator())
            {
                textBox1.AppendText("+");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            checkTextBoxMode();
            textBox1.AppendText("8");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            checkTextBoxMode();
            textBox1.AppendText("2");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkTextBoxMode();
            textBox1.AppendText("1");

        }

        private void button8_Click(object sender, EventArgs e)
        {
            checkTextBoxMode();
            textBox1.AppendText("3");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            checkTextBoxMode();
            textBox1.AppendText("4");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            checkTextBoxMode();
            textBox1.AppendText("5");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            checkTextBoxMode();
            textBox1.AppendText("6");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            checkTextBoxMode();
            textBox1.AppendText("7");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            checkTextBoxMode();
            textBox1.AppendText("9");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            checkTextBoxMode();
            textBox1.AppendText("0");
        }

        private void minus_Click(object sender, EventArgs e)
        {
            checkTextBoxMode();
            if (checkLastFieldForOperator())
            {
                textBox1.AppendText("-");
            }
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            checkTextBoxMode();
            if (checkLastFieldForOperator())
            {
                textBox1.AppendText("*");
            }
        }

        private void divide_Click(object sender, EventArgs e)
        {
            checkTextBoxMode();
            if(checkLastFieldForOperator())
            {
                textBox1.AppendText("/");
            }
        }

        private void equals_Click(object sender, EventArgs e)
        {
            textBox1.Text = CalculationProcessor.CalculateExpression(textBox1.Text).ToString();
            textboxContainsResult = true;
        }

        private void checkTextBoxMode()
        {
            if(textboxContainsResult)
            {
                textBox1.Text = "";
                textboxContainsResult = false;
            }
        }

        private bool checkLastFieldForOperator()
        {
            if (textBox1.Text.Length > 0 && operators.Contains(textBox1.Text.Last()))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkTextBoxMode();
            textBox1.AppendText("(");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            checkTextBoxMode();
            textBox1.AppendText(")");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(".");
        }
    }
}
