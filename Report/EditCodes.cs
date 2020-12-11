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
{
    public partial class EditCodes : Form
    {       
        //REPORTGENERATE - EDIT CODES FORM
         //2020 ALISTAIR BRAZIER
        public EditCodes()
        {
            InitializeComponent();
        }



        private void EditCodes_Load(object sender, EventArgs e)
        /// <summary>
        /// Gets the name of the code from dropdown, and then assigns it to a code selector
        /// </summary>

        {
            DataSet getName = DBConnection.getInstanceOfDBConnection().getDataSet("SELECT Code from Codes"); //get the code name to change
            codeSelector.DisplayMember = "code"; //dropdown display member to the code
            codeSelector.DataSource = getName.Tables[0]; //datasource to the code
        }

        private void codeSelector_SelectedIndexChanged(object sender, EventArgs e) //when the selection is changed
        /// <summary>
        /// Gets new code data when the selection is changed
        /// </summary>

        {
            DataSet getID = DBConnection.getInstanceOfDBConnection().getDataSet("SELECT ID FROM Codes WHERE code='" + codeSelector.Text + "'"); //select the id
            idBox.DataBindings.Clear();
            idBox.DataBindings.Add("text", getID.Tables[0], "id"); //bind to informational text box
            DataSet editBody = DBConnection.getInstanceOfDBConnection().getDataSet("SELECT Feedback FROM Codes WHERE code='" + codeSelector.Text + "'"); //and for code body
            codeBody.DataBindings.Clear(); 
            codeBody.DataBindings.Add("text", editBody.Tables[0], "Feedback");
            DataSet editName = DBConnection.getInstanceOfDBConnection().getDataSet("SELECT DISTINCT Code FROM Codes WHERE code='" + codeSelector.Text + "'"); //and for code title
            codeTitle.DataBindings.Clear(); 
            codeTitle.DataBindings.Add("text", editName.Tables[0], "Code");
        }

        private void saveUpdate_Click(object sender, EventArgs e) //when save hit
        /// <summary>
        /// Checks user's inputs then saves to database
        /// </summary>
  
        {
            bool check = CheckUserInput(codeTitle.Text,codeBody.Text); //Check input

            if (check == false) //checking whether the fields are all filled
            {
                MessageBox.Show("Please enter a value"); //If not, show an error
            }
            else
            {
                DataSet ds = DBConnection.getInstanceOfDBConnection().getDataSet("UPDATE Codes SET Code ='" + codeTitle.Text + "', Feedback='" + codeBody.Text + "' WHERE Id='" + idBox.Text + "'"); //set the code in db
                MessageBox.Show("Your  code was succesfully updated");//Tell user about this
                this.Close();
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
