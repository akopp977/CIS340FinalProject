using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace finalProject
{
    //This is the general form error used when user input is invalid/would cause and error and 
    //Helps user to correct behavior with the error message
    public partial class ErrorForm : Form
    {
        //Constructor takes message as input determined at point of error in code
        public ErrorForm(string errormessage)
        {
            InitializeComponent();
            rtxt_ErrorMessage.SelectionAlignment = HorizontalAlignment.Center;
            rtxt_ErrorMessage.Text = "ERROR" + Environment.NewLine + errormessage;
        }
        //Clicking ok is the only way to exit the error form
        private void btn_Ok_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
