using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace binaryConvert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //***********************************************************************************************************************************
        //         CLICK EVENTS
        //***********************************************************************************************************************************
        private void numberBtn_Click(object sender, EventArgs e)
        {
           lblDisplay.Text = lblDisplay.Text + returnButtonText(sender);  // Get the text value from buttons
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            // Safely remove the last character if there is one
            string currentText = lblDisplay.Text;
            if (!string.IsNullOrEmpty(currentText))
                lblDisplay.Text = currentText.Remove(currentText.Length - 1);
        }


        //***********************************************************************************************************************************
        //         METHODS
        //***********************************************************************************************************************************
        private string returnButtonText(object sender) // Method for returns text of button clicked 
        {
            Button clickedButton = (Button)sender; //Cast the sender to a Button so we can access its properties
            return clickedButton.Text;
        }// end of returnButtonText method

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

            //convert to decimal
            int decimalNumber = Convert.ToInt32(binaryNumber, 2);

            //display the decimal number
            lblDisplay.Text = decimalNumber.ToString();
        }
    }
}
