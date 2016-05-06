using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntroDemo
{
    public partial class Calculator : Form
    {
        private Form1 form1;
        private enum Operation { Addition, Subtraction, Division, Multiplication };
        private enum LastKeyInput { Digit, Operator, Equal, DecimalPoint, Sign }

        decimal? digitMemory = null;
        decimal? totalMemory = null;

        Operation? operationMemory = null;

        LastKeyInput? lastKeyInput = LastKeyInput.Digit;

        public Calculator(Form1 f1)
        {
            InitializeComponent();
            form1 = f1;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            RenderCurrentValue(resultText.Text, "0");
            resultText.Text = digitMemory.ToString();
            Calculate();
            lastKeyInput = LastKeyInput.Digit;
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            //handles if decimal point is the first input after calculation
            if (lastKeyInput != LastKeyInput.Digit && lastKeyInput != LastKeyInput.DecimalPoint && lastKeyInput != LastKeyInput.Sign)
            {
                resultText.Text = ".";
                lastKeyInput = LastKeyInput.DecimalPoint;
                return;
            }
            //handles multiple decimal point
            if (!resultText.Text.Contains("."))
            {
                resultText.Text = digitMemory.ToString() + ".";
                lastKeyInput = LastKeyInput.DecimalPoint;
            }
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            lastKeyInput = LastKeyInput.Equal;
            resultText.Text = totalMemory.ToString();
            ResetMemory();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Renders Text on Screen
            RenderCurrentValue(resultText.Text, "1");
            resultText.Text = digitMemory.ToString();

            //Perform calculation based on current operator
            Calculate();
            lastKeyInput = LastKeyInput.Digit;


            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RenderCurrentValue(resultText.Text, "2");
            resultText.Text = digitMemory.ToString();
            Calculate();
            lastKeyInput = LastKeyInput.Digit;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RenderCurrentValue(resultText.Text, "3");
            resultText.Text = digitMemory.ToString();
            Calculate();
            lastKeyInput = LastKeyInput.Digit;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RenderCurrentValue(resultText.Text, "4");
            resultText.Text = digitMemory.ToString();
            Calculate();
            lastKeyInput = LastKeyInput.Digit;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RenderCurrentValue(resultText.Text, "5");
            resultText.Text = digitMemory.ToString();
            Calculate();
            lastKeyInput = LastKeyInput.Digit;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RenderCurrentValue(resultText.Text, "6");
            resultText.Text = digitMemory.ToString();
            Calculate();
            lastKeyInput = LastKeyInput.Digit;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RenderCurrentValue(resultText.Text, "7");
            resultText.Text = digitMemory.ToString();
            Calculate();
            lastKeyInput = LastKeyInput.Digit;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            RenderCurrentValue(resultText.Text, "8");
            resultText.Text = digitMemory.ToString();
            Calculate();
            lastKeyInput = LastKeyInput.Digit;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            RenderCurrentValue(resultText.Text, "9");
            resultText.Text = digitMemory.ToString();
            Calculate();
            lastKeyInput = LastKeyInput.Digit;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (lastKeyInput == LastKeyInput.Digit || lastKeyInput == LastKeyInput.Operator)
            {
                operationMemory = Operation.Addition;
            }
            resultText.Text = totalMemory.ToString();
            lastKeyInput = LastKeyInput.Operator;
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            if (lastKeyInput == LastKeyInput.Digit || lastKeyInput == LastKeyInput.Operator)
            {
                operationMemory = Operation.Subtraction;
            }
            resultText.Text = totalMemory.ToString();
            lastKeyInput = LastKeyInput.Operator;
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            if (lastKeyInput == LastKeyInput.Digit || lastKeyInput == LastKeyInput.Operator)
            {
                operationMemory = Operation.Multiplication;
            }
            resultText.Text = totalMemory.ToString();
            lastKeyInput = LastKeyInput.Operator;
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            if (lastKeyInput == LastKeyInput.Digit || lastKeyInput == LastKeyInput.Operator)
            {
                operationMemory = Operation.Division;
            }
            resultText.Text = totalMemory.ToString();
            lastKeyInput = LastKeyInput.Operator;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            resultText.Text = "";
            ResetMemory();
        }

        private void buttonNegative_Click(object sender, EventArgs e)
        {
            //handles if negative sign is the first input after calculation
            if (lastKeyInput != LastKeyInput.Digit && lastKeyInput != LastKeyInput.DecimalPoint && lastKeyInput != LastKeyInput.Sign)
            {
                resultText.Text = "-";
                lastKeyInput = LastKeyInput.Sign;
                return;
            }
            //handles multiple negative sign
            if (!resultText.Text.Contains("-"))
            {
                resultText.Text = "-" + digitMemory.ToString();
                lastKeyInput = LastKeyInput.Sign;
            }
        }

        private void button_Click(object sender, EventArgs e)
        {

        }

        private void Calculate()
        {
            if (operationMemory != null)
            {
                switch (operationMemory)
                {
                    case Operation.Addition:
                        if (totalMemory == null)
                        {
                            //Handles first entry
                            totalMemory = digitMemory;
                        }
                        else
                        {
                            totalMemory = totalMemory + digitMemory;
                        }
                        lastKeyInput = LastKeyInput.Operator;
                        break;

                    case Operation.Subtraction:
                        if (totalMemory == null)
                        {
                            //Handles first entry
                            totalMemory = digitMemory;
                        }
                        else
                        {
                            totalMemory = totalMemory - digitMemory;
                        }
                        lastKeyInput = LastKeyInput.Operator;
                        break;

                    case Operation.Multiplication:
                        if (totalMemory == null)
                        {
                            //Handles first entry
                            totalMemory = digitMemory;
                        }
                        else
                        {
                            totalMemory = totalMemory * digitMemory;
                        }
                        lastKeyInput = LastKeyInput.Operator;
                        break;

                    case Operation.Division:
                        if (totalMemory == null)
                        {
                            //Handles first entry
                            totalMemory = digitMemory;
                        }
                        else
                        {
                            totalMemory = totalMemory / digitMemory;
                        }
                        lastKeyInput = LastKeyInput.Operator;
                        break;
                }
            }
            else
            {

                totalMemory = digitMemory;

            }
        }

        private void RenderCurrentValue(string currentRenderedValue, string character)
        {
            //display multiple digits
            if (lastKeyInput == LastKeyInput.Digit || lastKeyInput == LastKeyInput.DecimalPoint || lastKeyInput == LastKeyInput.Sign)
            {
                digitMemory = decimal.Parse(currentRenderedValue + character);
            }
            else
            {
                digitMemory = decimal.Parse(character);
            }
        }

        private void ResetMemory()
        {
            totalMemory = null;
            digitMemory = null;
            operationMemory = null;
            lastKeyInput = LastKeyInput.Digit;
        }

        private void Calculator_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Show();
        }
    }
}
