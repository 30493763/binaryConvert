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
