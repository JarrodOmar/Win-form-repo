using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {

        string operators = "";
       
        public Form1()
        {
            InitializeComponent();
        }
        // addiing buttons  

        private void oneButton_Click(object sender, EventArgs e)
        {
         
                calculatorDisplay.Text = calculatorDisplay.Text + "1";
            
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            
                calculatorDisplay.Text = calculatorDisplay.Text + "2";
            
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
           
                calculatorDisplay.Text = calculatorDisplay.Text + "3";
            
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            
                calculatorDisplay.Text = calculatorDisplay.Text + "4";
            
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
          
                calculatorDisplay.Text = calculatorDisplay.Text + "5";

        }

        private void sixButton_Click(object sender, EventArgs e)
        {
          
                calculatorDisplay.Text = calculatorDisplay.Text + "6";
            
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
          
                calculatorDisplay.Text = calculatorDisplay.Text + "7";
            
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
           
                calculatorDisplay.Text = calculatorDisplay.Text + "8";
            
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
         
                calculatorDisplay.Text = calculatorDisplay.Text + "9";
            
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
           
            
                calculatorDisplay.Text = calculatorDisplay.Text + "0";
            
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            
            operators = "+";
            calculatorDisplay.Text = calculatorDisplay.Text + operators;
            
        }

        private void minusButton_Click(object sender, EventArgs e)
        {

            operators = "-";
            calculatorDisplay.Text = calculatorDisplay.Text + operators;
            
        }

        private void multiplyBuytton_Click(object sender, EventArgs e)
        {

            operators = "*";
            calculatorDisplay.Text = calculatorDisplay.Text + operators;
            
        }

        private void divideButton_Click(object sender, EventArgs e)
        {

            operators = "/";
            calculatorDisplay.Text = calculatorDisplay.Text + operators;
            
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {

            try
            {
                // using Compute method of the Datatable class to evaluate the string(expression)
                var result = new System.Data.DataTable().Compute(calculatorDisplay.Text, null);
                //converting result to display on screen 
                calculatorDisplay.Text = result.ToString();
            }
            catch (Exception ex)
            {
                // catching any errors that may occur and display error message 
                MessageBox.Show("Invalid Expression: " + ex.Message);
            }

        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
         
                calculatorDisplay.Text = calculatorDisplay.Text + ".";
            
        }

        private void rightBracketButton_Click(object sender, EventArgs e)
        {
          
                calculatorDisplay.Text = calculatorDisplay.Text + "(";
            
        }

        private void leftBracketButton_Click(object sender, EventArgs e)
        {
            
                calculatorDisplay.Text = calculatorDisplay.Text + ")";
            
        }
    }
}
