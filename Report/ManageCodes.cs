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
    public partial class ManageCodes : Form
    {

        //REPORTGENERATE - MANAGE CODES FORM
        //2020 ALISTAIR BRAZIER
        public ManageCodes()
        {
            InitializeComponent();
        }
        private void ManageCodes_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void ManageCodes_Load(object sender, EventArgs e) //As soon as the form opens
        /// <summary>
        /// Populates DGV with info, then adds the delete button
        /// </summary>

        {
            DataSet codeView = DBConnection.getInstanceOfDBConnection().getDataSet("SELECT * FROM Codes"); //Get the codes
            codeManageDGV.DataSource = codeView.Tables[0]; //Set DGV's source to the set
            var deleteButton = new DataGridViewButtonColumn(); //Add the deletion button
            deleteButton.Name = "deleteButton"; //name
            deleteButton.HeaderText = "Delete"; //header
            deleteButton.Text = "Delete"; //text
            deleteButton.UseColumnTextForButtonValue = true; //Show text on button
            this.codeManageDGV.Columns.Add(deleteButton); //Add the button
            codeManageDGV.Columns[0].HeaderCell.Value = "ID"; //Change DGV's col names so they look nice
            codeManageDGV.Columns[1].HeaderCell.Value = "Code Name"; //Change DGV's col names so they look nice
            codeManageDGV.Columns[2].HeaderCell.Value = "Code Body"; //Change DGV's col names so they look nice
        }

        private void addCodes_Click(object sender, EventArgs e) //Open the Add Code screen once clicked

        {
            new AddCode().Show();
        }

        private void editButton_Click(object sender, EventArgs e) //Open the Edit Code screen once clicked
        {
            new EditCodes().Show();
        }

        private void codeManageDGV_CellContentClick(object sender, DataGridViewCellEventArgs e) //Deleting the code
        /// <summary>
        /// Lets the user delete a code
        /// </summary>

        {
            int colIndex = codeManageDGV.CurrentCell.ColumnIndex; //get col
            int rowIndex = codeManageDGV.CurrentCell.RowIndex; //get row


            if (colIndex == 0) //If col index is 0
            {
                string selectedId = codeManageDGV.Rows[rowIndex].Cells[1].Value.ToString(); //ascertain selected ID
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult confirmation = MessageBox.Show("Are you sure you want to delete this?", "Warning", buttons); //Message box, ask user if sure
                if (confirmation == DialogResult.Yes)
                {
                    DataSet deletion = DBConnection.getInstanceOfDBConnection().getDataSet("DELETE from Codes WHERE id = '" + selectedId + "'"); //Then delete
                    DataSet data = DBConnection.getInstanceOfDBConnection().getDataSet("SELECT * FROM Codes"); //get the new data
                    codeManageDGV.DataSource = data.Tables[0];
                }
                else
                {
                    return;
                }
            }
        }
            
        private void refresh_Click(object sender, EventArgs e) //refresh for new data
        /// <summary>
        /// Data refresh
        /// </summary>

        {
            DataSet data = DBConnection.getInstanceOfDBConnection().getDataSet("SELECT * FROM Codes");
            codeManageDGV.DataSource = data.Tables[0];
        }
    }
}
