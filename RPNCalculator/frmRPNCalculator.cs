/* frmRPNCalculator.cs
 * 
 * This program generates an RPN calculator form
 * 
 * Created By: Ankit Sadana
 * Created On: 12/02/2014
 * Last Modified By: Ankit Sadana
 * Last Modified On: 12/05/2014
 * IU Username: asadana
 * 
 * Assignment #3 for A590
 * Part of: RPNCalculator Project
 */

// Libraries being used for this Form
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Project Name: RPNCalculator
namespace RPNCalculator
{
    // Sub main class for this form
    public partial class frmRPNCalculator : Form
    {
        // Defining double type variables for all three text boxes
        // These are used to store the numbers for them
        double dblFirstNum = 0;
        double dblSecondNum = 0;
        double dblAnswer = 0;

        // Defining string variables for all three text boxes
        // These are used to fetch and display the values while they are used in double variables
        string strFirstNum = "0";
        string strSecondNum = "0";
        string strAnswer = "0";
        
        // Defining a string variable to temporarily store and check if a number is entered
        string strTest = "0";
        // Defining a double variable to store the converted string temporarily
        double dblNumCheck = 0;
        // Defining a boolean variable to set as true if number entered is numeric
        public bool isNum;

        // Function called when the form is being initialized
        public frmRPNCalculator()
        {
            // Initializing the form component
            InitializeComponent();
        }

        // Function called when the form is being loaded
        private void frmRPNCalculator_Load(object sender, EventArgs e)
        {
            // Setting default values to all three text boxes
            txtFirstNum.Text = "0";
            txtSecondNum.Text = "0";
            txtAnswer.Text = "";

            // Moving the focus for the user to the first text box
            txtFirstNum.Focus();
        }

        // Function called when the form is being closed
        private void frmRPNCalculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            // If statement displays a dialog box asking for user confirmation before closing
            if(MessageBox.Show("Are you sure you want to quit?","Confirm Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
            {
                // If the user selects no, form closing is canceled
                e.Cancel = true;
            }
        }

        // ----- Start of input handling code

        // Function called when the user leaves the txtFirstNum textbox in any way
        private void txtFirstNum_Leave(object sender, EventArgs e)
        {
            // Fetching the text from txtFirstNum, converting it to a string and storing it in strFirstNum
            strFirstNum = txtFirstNum.Text.ToString();

            // Copying the strFirstNum temporarily into strTest for testing if it's numeric
            strTest = strFirstNum;

            // Attempting to type convert from strTest and store it ino dblNumCheck,
            // if successful, isNum is set to true
            bool isNum = double.TryParse(strTest, out dblNumCheck);

            // If statement checks if the conversion was a success (if isNum is true)
            if (isNum)
            {
                // converting the strFirstNum to double, storing it to dblFirstNum
                dblFirstNum = double.Parse(strFirstNum);
            }
            // If statement checks if the string was just empty
            else if (strTest == "")
            {
                // Resetting the txtFirstNum and dblFirstNum to 0
                txtFirstNum.Text = "0";
                dblFirstNum = 0;
            }
            else
            {
                // Resetting the txtFirstNum to 0 and strFirstNum to empty
                txtFirstNum.Text = "0";
                strFirstNum = "";

                // An error message displayed to let the user know that a non-numeric value was entered into txtFirstNum
                MessageBox.Show("That is not a number.\nPlease and try again", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // Function called when the user leaves the txtSecondNum textbox in any way
        private void txtSecondNum_Leave(object sender, EventArgs e)
        {
            // Fetching the text from txtSecondNum, converting it to a string and storing it in strSecondNum
            strSecondNum = txtSecondNum.Text.ToString();

            // Copying the strSecondNum temporarily into strTest for testing if it's numeric
            strTest = strSecondNum;

            // Attempting to type convert from strTest and store it ino dblNumCheck,
            // if successful, isNum is set to true
            bool isNum = double.TryParse(strTest, out dblNumCheck);

            // If statement checks if the conversion was a success (if isNum is true)
            if (isNum)
            {
                // converting the strSecondNum to double, storing it to dblSecondNum
                dblSecondNum = double.Parse(strSecondNum);
            }
            // If statement checks if the string was just empty
            else if (strTest == "")
            {
                // Resetting the txtSecondNum and dblSecondNum to 0
                txtSecondNum.Text = "0";
                dblSecondNum = 0;

            }
            else
            {
                // Resetting the txtSecondNum and dblSecondNum to 0 
                txtSecondNum.Text = "0";
                strSecondNum = "";

                // An error message displayed to let the user know that a non-numeric value was entered into txtSecondNum
                MessageBox.Show("That is not a number.\nPlease and try again", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // Function called when any mouse button is clicked over txtFirstNum text box
        private void txtFirstNum_MouseDown(object sender, MouseEventArgs e)
        {
            // Emptying the textbox so that user can enter a value
            txtFirstNum.Text = "";
        }

        // Function called when any mouse button is clicked over txtSecondNum text box
        private void txtSecondNum_MouseDown(object sender, MouseEventArgs e)
        {
            // Emptying the textbox so that user can enter a value
            txtSecondNum.Text = "";
        }

        // End of input handling code ------

        // ----- Start of button functions

        // Function called when the Add (x + y) is clicked
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // values from dblFirstNum and dblSecondNum are added and placed into dblAnswer
            dblAnswer = (dblFirstNum + dblSecondNum);
            // dblAnswer is converted to a string
            strAnswer = dblAnswer.ToString();
            // The converted dblAnswer string is set as the value for the txtAnswer text box
            txtAnswer.Text = strAnswer;

            // Changing the text of label to show addition
            lblAnswer.Text = "Answer (x + y)";
        }

        // Function called when the Subtract (x - y) button is clicked
        private void btnSubtract_Click(object sender, EventArgs e)
        {
            // value from dblFirstNum is subtracted from dblSecondNum and placed into dblAnswer
            dblAnswer = (dblFirstNum - dblSecondNum);
            // dblAnswer is converted to a string
            strAnswer = dblAnswer.ToString();
            // The converted dblAnswer string is set as the value for the txtAnswer text box
            txtAnswer.Text = strAnswer;

            // Changing the text of label to show subtraction
            lblAnswer.Text = "Answer (x - y)";
        }

        // Function called when the Multiply (x * y) button is clicked
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            // values from dblFirstNum and dblSecondNum are multiplied and placed into dblAnswer
            dblAnswer = (dblFirstNum * dblSecondNum);
            // dblAnswer is converted to a string
            strAnswer = dblAnswer.ToString();
            // The converted dblAnswer string is set as the value for the txtAnswer text box
            txtAnswer.Text = strAnswer;

            // Changing the text of label to show multiplication
            lblAnswer.Text = "Answer (x * y)";
        }

        // Function called when the Divide (x / y) button is clicked
        private void btnDivide_Click(object sender, EventArgs e)
        {
            // If statement checks if the second number is not zero
            if (dblSecondNum != 0)
            {
                // value from dblFirstNum is divided by dblSecondNum and placed into dblAnswer
                dblAnswer = (dblFirstNum / dblSecondNum);
                // dblAnswer is converted to a string
                strAnswer = dblAnswer.ToString();
                // The converted dblAnswer string is set as the value for the txtAnswer text box
                txtAnswer.Text = strAnswer;

                // Changing the text of label to show division
                lblAnswer.Text = "Answer (x / y)";
            }
            else
            {
                // Displaying an error message for the user, letting them know that a number can't be divided by zero
                MessageBox.Show("Divisor cannot be 0\nPlease enter a different value and try again","Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        // Function called when the Remainder (x % y) button is clicked
        private void btnRem_Click(object sender, EventArgs e)
        {
            // If statement checks if the second number is not zero
            if (dblSecondNum != 0)
            {
                // value from dblFirstNum is divided by dblSecondNum and remainder is placed into dblAnswer
                dblAnswer = (dblFirstNum % dblSecondNum);
                // dblAnswer is converted to a string
                strAnswer = dblAnswer.ToString();
                // The converted dblAnswer string is set as the value for the txtAnswer text box
                txtAnswer.Text = strAnswer;

                // Changing the text of label to show remainder operation
                lblAnswer.Text = "Answer (x % y)";
            }
            else
            {
                // Displaying an error message for the user, letting them know that a number can't be divided by zero
                MessageBox.Show("Divisor cannot be 0\nPlease enter a different value and try again", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Function called when the ((x + y)^2) button is clicked
        private void btnWholePos_Click(object sender, EventArgs e)
        {
            // values from dblFirstNum and dblSecondNum are added
            dblAnswer = (dblFirstNum + dblSecondNum);
            // dblAnswer is multiplied with itself to square the answer
            dblAnswer *= dblAnswer;
            // dblAnswer is converted to a string
            strAnswer = dblAnswer.ToString();
            // The converted dblAnswer string is set as the value for the txtAnswer text box
            txtAnswer.Text = strAnswer;

            // Changing the text of label to show whole square operation
            lblAnswer.Text = "Answer (x + y)^2";
        }

        // Function called when the ((x - y)^2) button is clicked
        private void btnWholeNeg_Click(object sender, EventArgs e)
        {
            // values from dblFirstNum and dblSecondNum are subtracted
            dblAnswer = (dblFirstNum - dblSecondNum);
            // dblAnswer is multiplied with itself to square the answer
            dblAnswer *= dblAnswer;
            // dblAnswer is converted to a string
            strAnswer = dblAnswer.ToString();
            // The converted dblAnswer string is set as the value for the txtAnswer text box
            txtAnswer.Text = strAnswer;

            // Changing the text of label to show whole square operation
            lblAnswer.Text = "Answer (x - y)^2";            
        }

        // Function called when the OR (1/x + 1/y) button is clicked
        private void btnInvSum_Click(object sender, EventArgs e)
        {
            // If statement checks if the either number is not zero
            if (dblFirstNum != 0 && dblSecondNum != 0)
            {
                // values from dblFirstNum and dblSecondNum are added after being inversed
                dblAnswer = (1/dblFirstNum + (1/dblSecondNum));
                // dblAnswer is converted to a string
                strAnswer = dblAnswer.ToString();
                // The converted dblAnswer string is set as the value for the txtAnswer text box
                txtAnswer.Text = strAnswer;

                // Changing the text of label to show whole square operation
                lblAnswer.Text = "Answer (1/x + 1/y)";
            }
            else
            {
                // Displaying an error message for the user, letting them know that a number can't be divided by zero
                MessageBox.Show("Both numbers should be non-zero for this operation\nPlease enter a different value and try again", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Function called when the Clear button is clicked
        private void btnClear_Click(object sender, EventArgs e)
        {
            // All three text boxes are returned to their default values
            txtFirstNum.Text = "0";
            txtSecondNum.Text = "0";
            txtAnswer.Text = "";

            // All double variables that store values from text boxes are set to 0
            dblFirstNum = 0;
            dblSecondNum = 0;
            dblAnswer = 0;

            // Resetting the label to "Answer"
            lblAnswer.Text = "Answer";

            // Since everything is reset, we return the focus back to first textbox
            txtFirstNum.Focus();
        }

        // Function called when the Quit button is clicked
        private void btnQuit_Click(object sender, EventArgs e)
        {
            // Closing "this" form
            this.Close();
        }

        // End of button functions -----
     
    }
}
