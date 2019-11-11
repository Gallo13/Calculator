using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// JESSICA GALLO
// 12/4/2016
namespace Calculator3
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
// DECLARED VARIABLES
        float num1, result;
        double result2; //FOR OPERATIONS THAT NEED A DOUBLE NOT A FLOAT
        int count = 0;  // FOR SWITCH STATEMENT
// ZERO BUTTON
        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0; // INPUTING 0 TO TEXTBOX
        }
// ONE BUTTON
        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1; // INPUTING 1 TO TEXTBOX
        }
// TWO BUTTON
        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2; // INPUTING 2 TO TEXTBOX
        }
// THREE BUTTON
        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3; // INUPUTING 3  TO TEXTBOX
        }
// FOUR BUTTON
        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4; // INPUTING 4 TO TEXTBOX
        }
// FIVE BUTTON
        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5; // INPUTING 5 TO TEXTBOX
        }
// SIX BUTTON
        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6; // INPUTING 6 TO TEXTBOX
        }
// SEVEN BUTTON
        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7; // INPUTING 7 TO TEXTBOX
        }
// EIGHT BUTTON
        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8; // INPUTING 8 TO TEXTBOX
        }
// NINE BUTTON
        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9; // INPUTING 9 TO TEXTBOX
        }
// DOT BUTTON
        private void btnDot_Click(object sender, EventArgs e)
        {
            textBox1.Text += "."; // INPUTING A DOT TO TEXTBOX
        }
// ADD BUTTON
        private void btnAdd_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text); // GETTING THE FIRST NUMBER
            textBox1.Clear();   // CLEARING TEXTBOX
            textBox1.Focus();   // FOCUSING BACK ON THE TEXTBOX FOR THE NEXT NUMBER
            count = 4;  // CASE # FOR SWITCH STATEMENT
        }
// SUBTRACT BUTTON
        private void btnSub_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text); // GETTING THE FIRST NUMBER
            textBox1.Clear();   // CLEARING TEXTBOX
            textBox1.Focus();   // FOCUSING BACK ON THE TEXTBOX FOR THE NEXT NUMBER
            count = 3;  // CASE # FOR SWITCH STATEMENT
        }
// MULTIPLY BUTTON
        private void btnMul_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);  // GETTING THE FIRST NUMBER
            textBox1.Clear();   // CLEARING TEXTBOX
            textBox1.Focus();   // FOCUSING BACK ON THE TEXTBOX FOR THE NEXT NUMBER
            count = 2;  // CASE # FOR SWITCH STATEMENT
        }
// DIVIDE BUTTON
        private void btnDiv_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);  // GETTING THE FIRST NUMBER
            textBox1.Clear();   // CLEARING TEXTBOX
            textBox1.Focus();   // FOCUSING BACK ON THE TEXTBOX FOR THE NEXT NUMBER
            count = 1;  // CASE # FOR SWITCH STATEMENT
        }
// PI BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);  // GETTING THE FIRST NUMBER
            textBox1.Text += "π";   // INPUTING PI SYMBOL IN TEXTBOX
            count = 5;  // CASE # FOR SWITCH STATEMENT
        }
// CLEAR BUTTON
        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();   // CLEARING TEXTBOX
            count = 0;  // CASE # FOR SWITCH STATEMENT (NO CASE STATEMENT FOR THIS)
        }
// EQUAL BUTTON
        private void btnEqual_Click(object sender, EventArgs e)
        {
            compute(count); // COMPUTING INT COUNT FOR SWITCH STATEMENT
        }
// SQUARED BUTTON
        private void btnSquared_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);  // GETTING THE FIRST NUMBER
            textBox1.Text += "^2";  // INPUTING SQAURED SYMBOL TO TEXTBOX
            count = 6;  // CASE # IN SWITCH STATEMENT
        }
// CUBED BUTTON
        private void btnCubed_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);  // GETTING THE FIRST NUMBER
            textBox1.Text += "^3";  // INPUT CUBED SYMBOL TO TEXTBOX
            count = 7;  // CASE # IN SWITCH STATEMENT
        }
// SQUARE ROOT BUTTON
        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);  // GETTING THE FIRST NUMBER
            textBox1.Text += "√";   // INPUTING SQUARE ROOT SIGN TO TEXTBOX
            count = 8;  // CASE # IN SWITCH STATEMENT
        }
// SIN BUTTON
        private void btnSin_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);  // GETTING THE FIRST NUMBER
            count = 9;  // CASE # IN SWITCH STATEMENT
        }
// COS BUTTON
        private void btnCos_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);  // GETTING THE FIRST NUMBER
            count = 10; // CASE # IN SWITCH STATEMENT
        }
// TAN BUTTON
        private void btnTan_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);  // GETTING THE FIRST NUMBER
            count = 11; // CASE # IN SWITCH STATEMENT
        }

        // SWTCH STATEMENT FOR OPERATIONS
        public void compute(int count)
        {
            switch(count)   // CALLING THE COUNT INT FOR SWITCH STATMENT
            {
                    // DIVISION
                case 1: result = num1 / float.Parse(textBox1.Text); // MATH FOR DIVISION
                        textBox1.Text = result.ToString();  // CONVERT RESULT TO STRING
                        break;  // TO STOP
                    // MULTIPLICATION
                case 2: result = num1 * float.Parse(textBox1.Text); // MATH FOR MULTIPLICATION
                        textBox1.Text = result.ToString();  // CONVERT RESULT TO STRING
                        break;  // TO STOP
                    // SUBTRACTION
                case 3: result = num1 - float.Parse(textBox1.Text); // MATH FOR SUBTRACTION
                        textBox1.Text = result.ToString();  //CONVERT RESULT TO STRING
                        break;  // TO STOP
                    // ADDITION
                case 4: result = num1 + float.Parse(textBox1.Text); // MATH FOR ADDITION
                        textBox1.Text = result.ToString();  // CONVERT RESULT TO STRING
                        break;  // TO STOP
                    // PI
                case 5: result = num1 * (22 / 7);   // MATH FOR PI
                        textBox1.Text = result.ToString();  // CONVERT RESULT TO STRING
                        break;  // TO STOP
                    // SQUARED
                case 6: result2= Math.Pow(num1, 2); // MATH FOR SQAURING A #
                    textBox1.Text = result2.ToString(); // CONVERT RESULT2 TO STRING
                    break;  // TO STOP
                   // CUBED
                case 7: result2= Math.Pow(num1, 3); // MATH FOR CUBING A $
                    textBox1.Text = result2.ToString(); // CONVERT RESULT2 TO STRING
                    break;  // TO STOP
                   // SQUARE ROOT
                case 8: result2= Math.Sqrt(num1);   // MATH FOR SQUARE ROOT
                    textBox1.Text = result2.ToString(); // CONVERT RESULT2 TO STRING
                    break;  // TO STOP
                   // SIN
                case 9:result2 = Math.Sin(num1);    // MATH FOR SIN
                    textBox1.Text = result2.ToString(); // CONVERT RESULT2 TO STRING
                    break; // TO STOP
                   // COS
                case 10: result2 = Math.Cos(num1);  //  MATH FOR COS
                    textBox1.Text = result2.ToString(); // CONVERT RESULT2 TO STRING
                    break; // TO STOP
                   // TAN
                case 11: result2 = Math.Tan(num1);  // MATH FOR TAN
                    textBox1.Text = result2.ToString(); // CONVERT RESULT2 TO STRING
                    break; // TO STOP
                   // DEFAULT
                default: break;
            }
        }
    }
}
