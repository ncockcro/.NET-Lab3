/*
 * Written by: Nicholas Cockcroft
 * Date: 2/1/18
 * Course: .NET Environment
 * Assignment: Lab 3
 * 
 * Description: Write a program to uses a text box for input and a button to indicate when the user has entered new data. 
 * The data will be display on successive lines in a text box.
 * Make sure that there is space for at least 10 lines and allow scrolling. 
 * 
 * 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Lab3 : Form
    {
        public Lab3()
        {
            InitializeComponent();
        }

        private void computeButton_Click(object sender, EventArgs e)
        {
            // Store the input the user typed in to a string variable.
            string sinput = inputTextBox.Text;

            // Write user's input to the output text box.
            outputTextBox.Text += sinput;
            outputTextBox.Text += "\r\n";

            // Clear the input text box.
            inputTextBox.Text = "";

        }

        private void outputTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
