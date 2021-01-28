using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._0
{
    public partial class frmSimpleCalculator : Form
    {
        public frmSimpleCalculator()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Method that closes form when user clicks button
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Convert user input into decimals and operator into a string, use as arguments later
            decimal operand_1 = Convert.ToDecimal(txtOperandOne.Text);
            decimal operand_2 = Convert.ToDecimal(txtOperandTwo.Text);
            string operator_1 = txtOperator.Text;

            //Call method to calculate, insert arguments from above
            this.CalculateNumbers(operand_1, operand_2, operator_1);
        }

        //Make a method that takes three arguments
        private decimal CalculateNumbers(decimal operand_1, decimal operand_2, string operator_1)
        {
            //First, set result variable to 0 so it can be used in return statement
            decimal result = 0;

            //Use switch statement to decide which operation to perform on operands
            switch (txtOperator.Text)
            {
                //If the operator is +, then add the two operands together
                case "+":
                    result = operand_1 + operand_2;
                    break;

                //If the operator is -, then subtract the second operand from the first one
                case "-":
                    result = operand_1 - operand_2;
                    break;

                //If operator is *, multiply two operands together
                case "*":
                    result = operand_1 * operand_2;
                    break;

                //If operator is /, divide the first operand by second operand
                case "/":
                    result = operand_1 / operand_2;
                    break;
            }
            //Convert result into string and put answer in textbox
            txtResult.Text = Convert.ToString(result);

            //Since the method returns a decimal, the textbox needs to be converted back to decimal
            return Convert.ToDecimal(txtResult.Text);

        }
    }
}
