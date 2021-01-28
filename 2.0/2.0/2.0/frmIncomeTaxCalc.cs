using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2._0
{
    public partial class frmIncomeTaxCalc : Form
    {
        public frmIncomeTaxCalc()
        {
            InitializeComponent();
        }

        private void frmIncomeTaxCalc_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Method that will close form when button is clicked
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Turn taxable income into decimal and store in variable for easy usage
            decimal x = Convert.ToDecimal(txtTaxableIncome.Text);
            //Call method that calculates income tax
            this.CalculateIncomeTax(x);         
             

        }

        //Create a method to calculate income tax
        private decimal CalculateIncomeTax(decimal income)
        {
            //Convert user input to decimal and store in variable x
            decimal x = Convert.ToDecimal(txtTaxableIncome.Text);
            //Create variable a and set equal to 0, it will be used later in return statement
            decimal a = 0;
            //Use if for income under/equal to 9225
            if (x <= 9225)
            {
                //Multiply income by 10% and store in a
                a = x * Convert.ToDecimal(0.10);
            }

            //for income less than/equal to 37450
            else if (x <= 37450)
            {
                //Subtract 9225 to see how much is left over
                decimal b = Convert.ToDecimal(x - 9225);

                //If income less than 37450 and greater than 9225, then it will fall into the
                //"of excess over 9225" category
                //Multiple excess income by 0.15 and add 922.5
                a = ((b * Convert.ToDecimal(0.15)) + Convert.ToDecimal(922.5));
            }

            //Calculated like the previous, except multiply excess by 0.25 and add 5156.25
            else if (x <= 90750)
            {
                decimal b = Convert.ToDecimal(x - 9225);
                a = ((b * Convert.ToDecimal(0.25)) + Convert.ToDecimal(5156.25));
            }

            //Calculated like the previous, except multiply excess by 0.28 and add 18481.25
            else if (x <= 189300)
            {
                decimal b = Convert.ToDecimal(x - 9225);
                a = ((b * Convert.ToDecimal(0.28)) + Convert.ToDecimal(18481.25));
            }

            //Calculated like the previous, except multiply excess by 0.33 and add 46075.25
            else if (x <= 411500)
            {
                decimal b = Convert.ToDecimal(x - 9225);
                a = ((b * Convert.ToDecimal(0.33)) + Convert.ToDecimal(46075.25));
            }

            //Calculated like the previous, except multiply excess by 0.35 and add 119401.25
            else if (x <= 413200)
            {
                decimal b = Convert.ToDecimal(x - 9225);
                a = ((b * Convert.ToDecimal(0.35)) + Convert.ToDecimal(119401.25));
            }

            //Calculated like the previous, except multiply excess by 0.396 and add 119996.25
            else if (x > 413200)
            {
                decimal b = Convert.ToDecimal(x - 9225);
                a = ((b * Convert.ToDecimal(0.396)) + Convert.ToDecimal(119996.25));
            }

            //Convert a into string and display in textbox, round amount to two decimal places
            txtTaxOwed.Text = Convert.ToString(Math.Round(a, 2));

            //return statement for method
            return Convert.ToDecimal(txtTaxOwed.Text);
        }
    }
}
