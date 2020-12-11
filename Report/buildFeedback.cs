using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportGenerate
{
    public partial class BuildFeedback : Form
    {
        //REPORTGENERATE - MANAGE FEEDBACK FORM
        //2020 ALISTAIR BRAZIER
        public BuildFeedback()
        {
            InitializeComponent();
        }

        private void apTemplate_SelectedIndexChanged(object sender, EventArgs e)
        /// <summary>
        /// Displays the name of the template when the drop down box apTemplate is changed. 
        /// </summary>
        {
            DataSet getTemplate = DBConnection.getInstanceOfDBConnection().getDataSet("SELECT Name FROM Templates WHERE Id='" + apTemplate.Text + "'"); //Get the template
            template.DataBindings.Clear();
            template.DataBindings.Add("text", getTemplate.Tables[0], "name");
        }

        private void buildFeedback_Load(object sender, EventArgs e)
        /// <summary>
        /// When loaded, checks the codes table, adds the checkboxes, then changes their names to whatever they happen to be. Dynamic.
        /// </summary>

        {
            string codeString = SingleValueDB.databaseInstance().getString("SELECT COUNT(*) FROM CODES"); //Get the total count from codes list to detemine how many boxes
            int codeLength = Int32.Parse(codeString); //Parse this to the integer
            int value = 1;
            int position = 1;

            //Stack Overflow - User 'spajce', 2013. Dynamically Adding Checkboxes to a Windows Form Only Shows one Checkbox. 
            //[online] Available at: <https://stackoverflow.com/questions/15005333/dynamically-adding-checkboxes-to-a-windows-form-only-shows-one-checkbox> 
            //[Accessed 29 November 2020].
            for (int i = 1; i < codeLength + 1; i++) //One box for each code
            {
                try
                {
                    string codeName = SingleValueDB.databaseInstance().getString("SELECT Code FROM Codes WHERE Id='" + value + "'"); //get the code
                    CheckBox cb;
                    cb = new CheckBox(); //new checkbox
                    cb.Text = codeName;
                    cb.Location = new Point(10, position * 50); //iterate the position to have a list
                    panel1.Controls.Add(cb); //add to panel
                    value++;
                    position++; //increment value and position
                }

                catch (NullReferenceException) //If the code doesn't exist

                {
                    value++;
                    codeLength++;
                    continue; //Increment value, codelength and then continue as normal
                }
            }

            DataSet getTemplateID = DBConnection.getInstanceOfDBConnection().getDataSet("SELECT id FROM Templates"); //show ID
            apTemplate.DisplayMember = "id";
            apTemplate.DataSource = getTemplateID.Tables[0];
        }

        private void save_Click(object sender, EventArgs e) //Save button
        /// <summary>
        /// When saving the database, checkboxes are checked and a code string is made, other values are written to the database too here to build feedback.
        /// </summary>

        {

            List<string> codeRepresentations = new List<string>();

            //ITERATE THROUGH CHECKBOXES - First, get the kind of codes that are being used. 
            int chkBoxIterate = 1;

            //Stack Overflow - User 'Michal Franc', 2009. How can I iterate through all checkboxes on a form?
            //[online] Available at: <https://stackoverflow.com/questions/1788490/how-can-i-iterate-through-all-checkboxes-on-a-form> 
            //[Accessed 29 November 2020].

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
            //Again, check to see if everything is there, add to the db, or give user a warning to show they've not filled it all in
            string finalCBVals = String.Join(",", codeRepresentations);

            bool check = CheckUserInput(apName.Text, apMail.Text, apTemplate.Text, apFreeText.Text); //Check input

            if (check==false)
            {

                MessageBox.Show("Make sure that all fields are populated, then try again");
            }
            else
            {
                DataSet addToFeedBack = DBConnection.getInstanceOfDBConnection().getDataSet("INSERT INTO Feedback VALUES ('" + apName.Text + "','" + apMail.Text + "','" + apTemplate.Text + "','" + finalCBVals + "','" + apFreeText.Text + "')");
                MessageBox.Show("The feedback has been successfully created");
                this.Close();
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
   
