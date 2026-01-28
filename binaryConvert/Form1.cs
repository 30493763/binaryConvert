using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// aurthor: ching ho, Li
// student id: 30493763
// last update date: 23-jan-2026
// last update time: 11:58 AM
// description: This program that converts a 0 to 64 bits binary number into its decimal equivalent.
// github repo:https://github.com/30493763/binaryConvert.git

namespace binaryConvert
{


    public partial class Form1 : Form
    {
        const int MAX_BINARY_LENGTH = 64; // Maximum length for binary number
        bool RESULT_DISPLAYED = false; // Flag to indicate if result is displayed
        const string DEFAULT_DISPLAY = "--"; // Default display value
        public Form1()
        {
            InitializeComponent();
        }

        //***********************************************************************************************************************************
        //         CLICK EVENTS
        //***********************************************************************************************************************************
        private void numberBtn_Click(object sender, EventArgs e)
        {
            //get the binary number from the label
            string binaryNumber = lblDisplay.Text;


            //validate if the display is a  binary number, if not valid reset the display
            //if (RESULT_DISPLAYED)
            if (RESULT_DISPLAYED || (!RESULT_DISPLAYED && lblDisplay.Text == DEFAULT_DISPLAY) )

            {
                lblDisplay.Text = returnButtonText(sender);
                lblBitLengthResult.Text = "1";
                RESULT_DISPLAYED = false;
                lblResult.Text = "0";
                return;
            }

            if (binaryNumber.Length > MAX_BINARY_LENGTH-1)
            {
                MessageBox.Show("Please enter a binary number with a maximum of 64cbits.");
                return;
            }

            lblDisplay.Text = lblDisplay.Text + returnButtonText(sender);  // Get the text value from buttons

            lblBitLengthResult.Text = lblDisplay.Text.Length.ToString(); // Update the bit length display
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            // Safely remove the last character if there is one
            string currentText = lblDisplay.Text;
            if (!string.IsNullOrEmpty(currentText))
                lblDisplay.Text = currentText.Remove(currentText.Length - 1);
            else 
                lblDisplay.Text = DEFAULT_DISPLAY; 

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = DEFAULT_DISPLAY;
            RESULT_DISPLAYED = false;
            lblResult.Text = "0";
            lblBitLengthResult.Text = "0";
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //get the binary number from the label
            string binaryNumber = lblDisplay.Text;


            //validate the binary number
            if (string.IsNullOrEmpty(binaryNumber) || binaryNumber.Any(c => c != '0' && c != '1'))
            {
                MessageBox.Show("Please enter a valid binary number.");
                return;
            }

            //convert to decimal then display the decimal number
            lblResult.Text = Convert.ToInt64(binaryNumber, 2).ToString("#,##0"); // e.g. "123,456,789"
            RESULT_DISPLAYED = true;
        }

        //***********************************************************************************************************************************
        //         METHODS
        //***********************************************************************************************************************************
        private string returnButtonText(object sender) // Method for returns text of button clicked 
        {
            Button clickedButton = (Button)sender; //Cast the sender to a Button so we can access its properties
            return clickedButton.Text;
        }// end of returnButtonText method


    }
}
