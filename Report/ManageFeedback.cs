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
    //REPORTGENERATE - MANAGE FEEDBACK FORM
    //2020 ALISTAIR BRAZIER
    public partial class ManageFeedback : Form
    {
        public static string selectedId;
        public ManageFeedback()
        {
            InitializeComponent();
        }

        private void ManageFeedback_Load(object sender, EventArgs e)
        /// <summary>
        /// Gets the feedback, adds delete button, populates DGV
        /// </summary>

        {
            DataSet getFeedback = DBConnection.getInstanceOfDBConnection().getDataSet("SELECT * FROM Feedback"); //get the feeedback
            dgv1.DataSource = getFeedback.Tables[0]; //DGV with datasource as this feedback
            var deleteButton = new DataGridViewButtonColumn(); //add the delete button in
            deleteButton.Name = "dataGridViewDeleteButton";
            deleteButton.HeaderText = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;
            this.dgv1.Columns.Add(deleteButton);
            //Stack Overflow - User 'Ryan Spears', 2013. DataGridView Edit Column Names. [online] 
            //Available at: <https://stackoverflow.com/questions/125719/datagridview-edit-column-names/> [Accessed 29 November 2020].
            dgv1.Columns[0].HeaderCell.Value = "ID"; //Change DGV's col names so they look nice
            dgv1.Columns[1].HeaderCell.Value = "Name";
            dgv1.Columns[2].HeaderCell.Value = "Email";
            dgv1.Columns[3].HeaderCell.Value = "Template";
            dgv1.Columns[4].HeaderCell.Value = "Codes";
            dgv1.Columns[5].HeaderCell.Value = "Free Text";
        }

        private void build_Click(object sender, EventArgs e)
        {
            new BuildFeedback().Show(); //Open build feedback when clicked
        }
 
        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        /// <summary>
        /// Allows user to delete the feedback
        /// </summary>

        {
            int colIndex = dgv1.CurrentCell.ColumnIndex; //get col, row value
            int rowIndex = dgv1.CurrentCell.RowIndex;
            if (colIndex == 0) //Only prompt when button hit
            {
                // C# Corner, 2020. C# Message Box. [online] Available at: 
                //<https://www.c-sharpcorner.com/UploadFile/mahesh/understanding-message-box-in-windows-forms-using-C-Sharp/> [Accessed 29 November 2020].
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult confirmation = MessageBox.Show("Are you sure you want to delete this?", "Warning", buttons); //Message box, ask user if sure
                if (confirmation == DialogResult.Yes)
                {
                    selectedId = dgv1.Rows[rowIndex].Cells[1].Value.ToString();
                    DataSet deleteFeedback = DBConnection.getInstanceOfDBConnection().getDataSet("DELETE from Feedback WHERE id = '" + selectedId + "'");
                    DataSet data = DBConnection.getInstanceOfDBConnection().getDataSet("SELECT *  FROM Feedback "); //delete and refresh
                    dgv1.DataSource = data.Tables[0];
                }
                else
                {
                    return; //else, do nothing
                }

            }
        }

        private void edit_Click(object sender, EventArgs e)
        /// <summary>
        /// Checks whether the user's selected something, then brings up edit screen
        /// </summary>

       
        {
            //check if user's selected something
            try
            {
                int rowIndex = dgv1.CurrentCell.RowIndex;
                selectedId = dgv1.Rows[rowIndex].Cells[1].Value.ToString();
                new EditFeedback().Show();
            }
            catch (NullReferenceException)
           
            {
                MessageBox.Show("Please select the record ID you want to edit."); //Tell user
            }
        }        
        private void refresh_Click(object sender, EventArgs e)
        /// <summary>
        /// Data refresh
        /// </summary>

        {
            DataSet data = DBConnection.getInstanceOfDBConnection().getDataSet("SELECT * FROM Feedback "); //refresh
            dgv1.DataSource = data.Tables[0];
        }

        private void lbManageFeedback_Click(object sender, EventArgs e)
        {

        }
    }
}
