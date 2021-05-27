using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB10
{
    public partial class Form1 : Form
    {
        double firstNum = 0;
        char Operator;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            displayscreen.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            displayscreen.Text += "2";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            displayscreen.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            displayscreen.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            displayscreen.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            displayscreen.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            displayscreen.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            displayscreen.Text += "8";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            displayscreen.Text += "9";

        }

        private void button0_Click(object sender, EventArgs e)
        {
            displayscreen.Text += "0";

        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            displayscreen.Text = "";
            prevNum.Text = "";
        }

        private void buttondot_Click(object sender, EventArgs e)
        {
            displayscreen.Text += ".";
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            if (displayscreen.Text == "")
                MessageBox.Show("Please Enter a number..");
            else
            {
                firstNum = Convert.ToDouble(displayscreen.Text);
                Operator = '+';
                prevNum.Text = Operator + " " + firstNum;
                displayscreen.Text = "";
            }
        }

        private void prevNum_Click(object sender, EventArgs e)
        {

        }

        private void buttonsub_Click(object sender, EventArgs e)
        {
            if (displayscreen.Text == "")
                MessageBox.Show("Please Enter a number..");
            else
            {
                Operator = '-';
                firstNum = Convert.ToDouble(displayscreen.Text);
                prevNum.Text = Operator + " " + firstNum;
                displayscreen.Text = "";
            }
        }

        private void buttonmul_Click(object sender, EventArgs e)
        {
            if (displayscreen.Text == "")
                MessageBox.Show("Please Enter a number..");
            else
            {
                firstNum = Convert.ToDouble(displayscreen.Text);
                Operator = '*';
                prevNum.Text = Operator + " " + firstNum;
                displayscreen.Text = "";
            }
        }

        private void buttondiv_Click(object sender, EventArgs e)
        {
            if (displayscreen.Text == "")
                MessageBox.Show("Please Enter a number..");
            else
            {
                firstNum = Convert.ToDouble(displayscreen.Text);
                Operator = '/';
                prevNum.Text = Operator + " " + firstNum;
                displayscreen.Text = "";
            }
        }

        private void buttoneql_Click(object sender, EventArgs e)
        {
            if (displayscreen.Text == "")
                MessageBox.Show("Please Enter a number..");
            else
            {
                double secondNum = Convert.ToDouble(displayscreen.Text);
                switch (Operator)
                {
                    case '+':
                        prevNum.Text = "= " + (firstNum + secondNum);
                        break;
                    case '-':
                        prevNum.Text = "= " + (firstNum - secondNum);
                        break;
                    case '*':
                        prevNum.Text = "= " + (firstNum * secondNum);
                        break;
                    case '/':
                        prevNum.Text = "= " + (firstNum / secondNum);
                        break;
                    default:
                        break;
                }
                displayscreen.Text = "";
            }
        }
    }
}
