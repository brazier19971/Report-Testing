using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportGenerate
{        //REPORTGENERATE - ADD CODES FORM
         //2020 ALISTAIR BRAZIER
    public partial class AddCode : Form
    {
        public AddCode()
        {
            InitializeComponent();
        }
        private void save_Click(object sender, EventArgs e) //clicking the save button
        /// <summary>
        /// Checks the user's inputs are present, then adds them to the database.
        /// </summary>
        {
            bool check = CheckUserInput(codeTitle.Text,codeBody.Text); //Check input
            if (check == false) //checking whether the fields are all filled
            {
                MessageBox.Show("Please enter a value"); //If not, show an error
            }
            else
            {
                DataSet insertCode = DBConnection.getInstanceOfDBConnection().getDataSet("INSERT INTO Codes(Code, Feedback) VALUES('" + codeTitle.Text + "','" + codeBody.Text + "')"); //Insert into DB
                codeTitle.Text = ""; //blank title/body for new insertion
                codeBody.Text = "";
                MessageBox.Show("Your new code was succesfully added");//Tell user about this
            }
        }
        public bool CheckUserInput(string nameCheck, string bodyCheck)
        //Checks the user's input to ensure that they've put stuff in it!
        {
            bool result;
            if (nameCheck == "" || bodyCheck == "")
            {
                result = false;
            }
            else
            {
                result = true;
            }
            return result;
        }
    }
}
