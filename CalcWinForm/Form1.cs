using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcWinForm
{
    public partial class Form1 : Form
    {
        enum ops { add, subtract, divide, multiply, none };
        enum states { clear, op, ans };
        ops op = ops.none;
        states state = states.clear;
        double firstNum = 0;
        double secondNum = 0;
        double Result = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //calcController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (outBox.Text == "0" && outBox.Text != null)
            {
                outBox.Text = "1";
                runningOpBox.Text += "1";
            }
            else
            {
                outBox.Text = "1";
                runningOpBox.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (outBox.Text == "0" && outBox.Text != null)
            {
                outBox.Text = "2";
                runningOpBox.Text += "2";
            }
            else
            {
                outBox.Text = "2";
                runningOpBox.Text += "2";
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (outBox.Text == "0" && outBox.Text != null)
            {
                outBox.Text = "3";
                runningOpBox.Text += "3";
            }
            else
            {
                outBox.Text = "3";
                runningOpBox.Text += "3";
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (outBox.Text == "0" && outBox.Text != null)
            {
                outBox.Text = "4";
                runningOpBox.Text += "4";
            }
            else
            {
                outBox.Text = "4";
                runningOpBox.Text += "4";
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (outBox.Text == "0" && outBox.Text != null)
            {
                outBox.Text = "5";
                runningOpBox.Text += "5";
            }
            else
            {
                outBox.Text = "5";
                runningOpBox.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (outBox.Text == "0" && outBox.Text != null)
            {
                outBox.Text = "6";
                runningOpBox.Text += "6";
            }
            else
            {
                outBox.Text = "6";
                runningOpBox.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (outBox.Text == "0" && outBox.Text != null)
            {
                outBox.Text = "7";
                runningOpBox.Text += "7";
            }
            else
            {
                outBox.Text = "7";
                runningOpBox.Text += "7";
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (outBox.Text == "0" && outBox.Text != null)
            {
                outBox.Text = "8";
                runningOpBox.Text += "8";
            }
            else
            {
                outBox.Text = "8";
                runningOpBox.Text += "8";
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if(outBox.Text == "0" && outBox.Text != null)
            {
                outBox.Text = "9";
                runningOpBox.Text += "9";
            }
            else
            {
                outBox.Text = "9";
                runningOpBox.Text += "9";
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            outBox.Text += "0";
            runningOpBox.Text += "0";
        }
        private void perBtn_Click(object sender, EventArgs e)
        {
            outBox.Text += ".";
            
        }
        private void eqBtn_Click(object sender, EventArgs e)
        {
            runningOpBox.AppendText("=");
            secondNum = Convert.ToDouble(outBox.Text);
            Operations();
            state = states.ans;
        }
        private void additionBtn_Click(object sender, EventArgs e)
        {
            if(state == states.clear)
            {
                firstNum = Convert.ToDouble(outBox.Text);
                runningOpBox.AppendText("+");
                state = states.op;
                op = ops.add;
            }
            else if(state == states.op)
            {
                secondNum = Convert.ToDouble(outBox.Text);
                runningOpBox.Text = $"{firstNum} + {secondNum}";
                op = ops.add;
                Operations();
                state = states.ans;
            }
            else if (state==states.ans)
            {
                firstNum = Result;
                runningOpBox.Text = $"{firstNum} +";
                state = states.op;
                op = ops.add;
            }
        }

        private void subBtn_Click(object sender, EventArgs e)
        {
            if (state == states.clear)
            {
                firstNum = Convert.ToDouble(outBox.Text);
                runningOpBox.AppendText("-");
                state = states.op;
                op = ops.subtract;
            }
            else if (state == states.op)
            {
                secondNum = Convert.ToDouble(outBox.Text);
                runningOpBox.Text = $"{firstNum} - {secondNum}";
                op = ops.subtract;
                Operations();
                state = states.ans;
            }
            else if (state == states.ans)
            {
                firstNum = Result;
                runningOpBox.Text = $"{firstNum} - ";
                state = states.op;
                op = ops.subtract;
            }
        }
        private void multiBtn_Click(object sender, EventArgs e)
        {
            if (state == states.clear)
            {
                firstNum = Convert.ToDouble(outBox.Text);
                runningOpBox.AppendText("*");
                state = states.op;
                op = ops.multiply;
            }
            else if (state == states.op)
            {
                secondNum = Convert.ToDouble(outBox.Text);
                runningOpBox.Text = $"{firstNum} * {secondNum}";
                op = ops.multiply;
                Operations();
                state = states.ans;
            }
            else if (state == states.ans)
            {
                firstNum = Result;
                runningOpBox.Text = $"{firstNum} * ";
                state = states.op;
                op = ops.multiply;
            }
        }
        private void divBtn_Click(object sender, EventArgs e)
        {
            if (state == states.clear)
            {
                firstNum = Convert.ToDouble(outBox.Text);
                runningOpBox.AppendText("/");
                state = states.op;
                op = ops.divide;
            }
            else if (state == states.op)
            {
                secondNum = Convert.ToDouble(outBox.Text);
                runningOpBox.Text = $"{firstNum} / {secondNum}";
                op = ops.divide;
                Operations();
                state = states.ans;
            }
            else if (state == states.ans)
            {
                firstNum = Result;
                runningOpBox.Text = $"{firstNum} / ";
                state = states.op;
                op = ops.divide;
            }
        }
        
        public void Operations()
        {
            switch (op)
            {
                case ops.add:
                    Result = firstNum += secondNum;
                    outBox.Text = Convert.ToString(Result);
                    break;
                case ops.subtract:
                    Result = firstNum -= secondNum;
                    outBox.Text=$"{Result}";
                    break;
                case ops.multiply:
                    Result = firstNum *= secondNum;
                    outBox.Text=$"{Result}";
                    break;
                case ops.divide:
                    if (secondNum == 0)
                    {
                        outBox.Text = "Cannot Divide by 0";
                    }
                    else
                    {
                        Result = firstNum /= secondNum;
                        outBox.Text=$"{Result}";
                        break;
                    }
                    break;
            }
        }

        private void ClearEverythingButton_Click(object sender, EventArgs e)
        {
            outBox.Text = "0";
            runningOpBox.Text = "";
            state = states.clear;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            outBox.Text = "0";
            runningOpBox.Text = "";
            state = states.clear;
        }
    }
}
