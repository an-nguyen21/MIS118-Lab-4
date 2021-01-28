//
//Class: frmStudentGrades
//Author: Annie Nguyen
//Date: 1/26/2021
//Lab: Lab 4 Part 1
//Class Description: A user will input a score into the textbox and the program will assign a letter 
//grade to it
//
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._0
{
    public partial class frmStudentGrades : Form
    {
        public frmStudentGrades()
        {
            InitializeComponent();
        }

        //Creating a method to assign letter grade to score
        public string AssignGrade(int score)
        {
            //Set grade variable to empty string
            string grade = "";

            //If the score is less than 60, set grade to F
            if (score < 60)
            {
                grade = "F";
            }

            //If score greater than/equal to 60 and less than 70, set grade to D
            else if (score >= 60 & score < 70)
            {
                grade = "D";
            }

            //If score less than 80, set grade to C
            else if (score < 80)
            {
                grade = "C";
            }

            //If score greater than/equal to 80 and less than 90, set grade to B
            else if (score >= 80 & score < 90)
            {
                grade = "B";
            }

            //If score greater than/equal to 90, set grade to A
            else if (score >= 90)
            {
                grade = "A";
            }
                   
            return grade;
        }

        //Create new method to display an error box when input is not valid
        public void CheckValidInput(int UserInput)
        {
            
                //Including new form into this current form
                frmError errorMessage = new frmError();
                //Tells message box to show
                errorMessage.Show();               
          
            
            
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            //Convert user input into an int in order to use CheckValidInput method 
            int user = Convert.ToInt32(txtScoreInput.Text);
            //If user input is less than zero or greater than 100, use CheckValidInput message to 
            //display error box
            if (user < 0 || user > 100)
            {
                this.CheckValidInput(user);
            }
            
            //Use else if and pass it to DisplayMethod if above is false
            else if (user >= 0 & user <= 100)
            {
                string user2 = txtScoreInput.Text;
                this.DisplayMessage(user2);
            }
                
        }


        //Create a method to concatenate number and letter grade
        private string DisplayMessage(string concat)
        {
            
            //Convert user input into int and store in userInput variable
            int userInput = Convert.ToInt32(txtScoreInput.Text);

            //Set letter grade to displaymessage variable
            string displaymessage = Convert.ToString(AssignGrade(userInput));

            //Concatenation and return results
            lblResults.Text = "You entered a(n) " + txtScoreInput.Text + " which is a(n) " + displaymessage + " letter grade.";
            return lblResults.Text;
        }
        

        
    }
}
