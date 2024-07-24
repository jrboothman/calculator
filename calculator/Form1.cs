using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{


    public partial class Form1 : Form

    {
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double output = 0.0;
        public Form1()
        {
            InitializeComponent();

            AC.Parent = pictureBox1;
            Coutput.Parent = pictureBox1;
            button0.Parent = pictureBox1;
            button1.Parent = pictureBox1;
            button2.Parent = pictureBox1;
            button3.Parent = pictureBox1;
            button4.Parent = pictureBox1;
            button5.Parent = pictureBox1;
            button6.Parent = pictureBox1;
            button7.Parent = pictureBox1;
            button8.Parent = pictureBox1;
            button9.Parent = pictureBox1;
            plus.Parent = pictureBox1;
            minus.Parent = pictureBox1;
            times.Parent = pictureBox1;
            divide.Parent = pictureBox1;
            equals.Parent = pictureBox1;
            deci.Parent = pictureBox1;
        }

        private void AC_Click(object sender, EventArgs e)
        {
            this.Coutput.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            this.Coutput.Text = "";
            input += 0;
            this.Coutput.Text += input;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Coutput.Text = "";
            input += 1;
            this.Coutput.Text += input;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Coutput.Text = "";
            input += 2;
            this.Coutput.Text += input;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Coutput.Text = "";
            input += 3;
            this.Coutput.Text += input;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Coutput.Text = "";
            input += 4;
            this.Coutput.Text += input;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Coutput.Text = "";
            input += 5;
            this.Coutput.Text += input;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Coutput.Text = "";
            input += 6;
            this.Coutput.Text += input;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Coutput.Text = "";
            input += 7;
            this.Coutput.Text += input;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Coutput.Text = "";
            input += 8;
            this.Coutput.Text += input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Coutput.Text = "";
            input += 9;
            this.Coutput.Text += input;
        }

        private void plus_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;

        }

        private void minus_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void times_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void deci_Click(object sender, EventArgs e)
        {
            input += ".";
        }

        private void equals_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (operation == '+')
            {
                output = num1 + num2;
                Coutput.Text = output.ToString();
            }
            else if (operation == '-')
            {
                output = num1 - num2;
                Coutput.Text = output.ToString();
            }
            else if (operation == '*')
            {
                output = num1 * num2;
                Coutput.Text = output.ToString();
            }
            else if (operation == '/') 
            {
                if (num2 != 0)
                {
                    output = num1 / num2;
                    Coutput.Text = output.ToString();
                }
                else 
                {
                    Coutput.Text = "DIV/Zero";
                }
                   
            }

        }
    }
}
