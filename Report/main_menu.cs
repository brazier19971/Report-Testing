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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

  

        private void openChildForm(Form childForm)
        {
            AddOwnedForm(childForm);
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            this.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void bManageFeedback_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageFeedback());
        }

        private void bManageCodes_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageCodes());
        }

   
        private void pChildForm_Paint(object sender, PaintEventArgs e)
        {

        }
        //Register new user button - Added by Abdul
        private void addUser_Click(object sender, EventArgs e)
        {
           
        }

      
    }
}
