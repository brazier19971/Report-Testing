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

    //REPORTGENERATE - EDIT FEEDBACK FORM
    //2020 ALISTAIR BRAZIER
    public partial class EditFeedback : Form
    {
        public EditFeedback()
        {
            InitializeComponent();
        }

        internal DBConnection DBConnection
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        internal SingleValueDB SingleValueDB
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }



        private void EditFeedback_Load(object sender, EventArgs e)
        /// <summary>
        /// Gets codes, draws textboxes, adds info to boxes
        /// </summary>
  
        {
            string codeListString = SingleValueDB.databaseInstance().getString("SELECT COUNT(*) FROM CODES"); //Firstly, get the NUMBER of codes 
            int codeLength = Int32.Parse(codeListString); //Parse that to a string
            int cbBuildIteration = 1; //Used to identify current build iteration
            int position = 1; //Position guidelines for checkboxes
            

            for (int i = 1; i < codeLength + 1; i++) //Loop for the length of the code
            {
                try
                {
                    string nameCode = SingleValueDB.databaseInstance().getString("SELECT Code FROM Codes WHERE Id='" + cbBuildIteration + "'"); //Get the code name
                    CheckBox cb;
                    cb = new CheckBox(); //Make new textbox instance
                    cb.Text = nameCode; //Set that textbox's name to the name of the code
                    cb.Location = new Point(10, position * 50); //vary vertical position
                    panel1.Controls.Add(cb);//Add the checkbox to the panel
                    cbBuildIteration++;//Iterate 1
                    position++;//Iterate 1
                }

                catch (NullReferenceException) //In the event the code cannot be found....

                {
                    cbBuildIteration++;//Iterate again
                    codeLength++;//Add 1 to the length of the code 
                    continue;//Try again
                }

            }

            string getCodeList = SingleValueDB.databaseInstance().getString("SELECT codes_selected FROM Feedback WHERE Id='" + ManageFeedback.selectedId + "'"); //Get the codes
            string[] codesArray = getCodeList.Split(',');//Add those to an array
            int cboxSelectionId = 0;//Metahphorical 'ID' for the code


            foreach (Control c in panel1.Controls) //Loop through all of the checkboxes
            {

                if (c is CheckBox && c != null)
                {
                    try

                    {
                        var testExists = SingleValueDB.databaseInstance().getString("SELECT Code FROM Codes WHERE Id='" + codesArray[cboxSelectionId] + "'"); //Check if the code exists
                        if (codesArray[cboxSelectionId] != "0")//If it's NOT 0
                        { 
                            ((CheckBox)c).Checked = true; //Mark the box as checked
                        }
                        cboxSelectionId++;//Iterate
                    }
                    catch (NullReferenceException) //If the code is not found, no ID....
                    {
                        cboxSelectionId++; //Iterate
                        continue;//Continue
                    }
                    catch (IndexOutOfRangeException)
                    {
                        cboxSelectionId++; //Iterate
                        continue; //Continue
                    }
                }
            }

            List<string> codeRepresentations = new List<string>(); //Array for checkbox verification
            int chkBoxIterate = 1;

            foreach (Control c in panel1.Controls) //Loop through all of the checkboxes
            {
                if (c is CheckBox && c != null) //Same as the system for saving the codes in the build feedback stage
                {
                    // need code
                    if (((CheckBox)c).Checked)
                    {
                        codeRepresentations.Add(chkBoxIterate.ToString());
                        chkBoxIterate++;
                    }
                    else
                    {
                        codeRepresentations.Add("0");
                        chkBoxIterate++;
                    }
                }
            }
         
            DataSet idGet = DBConnection.getInstanceOfDBConnection().getDataSet("SELECT id FROM Templates"); 
            apTemplate.DisplayMember = "id";
            apTemplate.DataSource = idGet.Tables[0];


            // Add info
            DataSet applicantName = DBConnection.getInstanceOfDBConnection().getDataSet("SELECT Name FROM Feedback WHERE Id='" + ManageFeedback.selectedId + "'") ;
            apName.DataBindings.Clear();
            apName.DataBindings.Add("text", applicantName.Tables[0], "name");



            DataSet applicantEmail = DBConnection.getInstanceOfDBConnection().getDataSet("SELECT Email FROM Feedback WHERE Id='" + ManageFeedback.selectedId + "'");
            apMail.DataBindings.Clear(); 
            apMail.DataBindings.Add("text", applicantEmail.Tables[0], "email");


            DataSet applicantFreeText = DBConnection.getInstanceOfDBConnection().getDataSet("SELECT Free_text FROM Feedback WHERE Id='" + ManageFeedback.selectedId + "'");
            apFreeText.DataBindings.Clear(); 
            apFreeText.DataBindings.Add("text", applicantFreeText.Tables[0], "free_text");
        }

        private void apTemplate_SelectedIndexChanged(object sender, EventArgs e)
        /// <summary>
        /// Changes the template name box when ID is changed
        /// </summary>

        {
            DataSet templates = DBConnection.getInstanceOfDBConnection().getDataSet("SELECT Name FROM Templates WHERE Id='" + apTemplate.Text + "'");
            templateName.DataBindings.Clear(); 
            templateName.DataBindings.Add("text", templates.Tables[0], "name");
        }

        private void save_Click(object sender, EventArgs e)
        /// <summary>
        /// Builds a list of codes, then saves. Checks user input.
        /// </summary>


        {
            List<string> codeRepresentations = new List<string>();
            int chkBoxIterate = 1;

            foreach (Control c in panel1.Controls) //Loop through all of the checkboxes, if checked, add to the list, otherwise, add 0 to the list. 
            {


                if (c is CheckBox && c != null)
                {
                    // need code
                    if (((CheckBox)c).Checked)
                    {
                        codeRepresentations.Add(SingleValueDB.databaseInstance().getString("SELECT Id FROM Codes WHERE Code='" + c.Text + "'"));
                        chkBoxIterate++;
                    }
                    else
                    {
                        codeRepresentations.Add("0");
                        chkBoxIterate++;
                    }

                }

            }
            string finalCBVals = String.Join(",", codeRepresentations);


            bool check = CheckUserInput(apName.Text, apMail.Text, apTemplate.Text, apFreeText.Text); //Check input

            if (check == false)
            {

                MessageBox.Show("Make sure that all fields are populated, then try again");
            }
            else
            {
                DataSet addToFeedBack = DBConnection.getInstanceOfDBConnection().getDataSet("UPDATE Feedback SET name='" + apName.Text + "',email='" + apMail.Text + "',template_used='" + apTemplate.Text + "',codes_selected='" + finalCBVals + "',free_text='" + apFreeText.Text + "' WHERE ID ='" + ManageFeedback.selectedId + "'"); //Add to db
                MessageBox.Show("The update was successful."); // Tell user
                this.Close(); //Close
            }
        }


        public bool CheckUserInput(string nameCheck, string mailCheck, string templateCheck, string freetextCheck)
        //Checks the user's input to ensure that they've put stuff in it!
        {

            bool result;

            if (nameCheck == "" || mailCheck == "" || templateCheck == "" || freetextCheck == "")
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
