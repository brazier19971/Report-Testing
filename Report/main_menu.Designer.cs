namespace ReportGenerate
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbMenu = new System.Windows.Forms.Label();
            this.pSideMenu = new System.Windows.Forms.Panel();
            this.bManageFeedback = new System.Windows.Forms.Button();
            this.bManageCodes = new System.Windows.Forms.Button();
            this.pHeader = new System.Windows.Forms.Panel();
            this.pChildForm = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pSideMenu.SuspendLayout();
            this.pHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMenu
            // 
            this.lbMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMenu.AutoSize = true;
            this.lbMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMenu.Location = new System.Drawing.Point(89, 27);
            this.lbMenu.Name = "lbMenu";
            this.lbMenu.Size = new System.Drawing.Size(66, 25);
            this.lbMenu.TabIndex = 7;
            this.lbMenu.Text = "Menu";
            // 
            // pSideMenu
            // 
            this.pSideMenu.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pSideMenu.Controls.Add(this.label1);
            this.pSideMenu.Controls.Add(this.bManageFeedback);
            this.pSideMenu.Controls.Add(this.bManageCodes);
            this.pSideMenu.Controls.Add(this.pHeader);
            this.pSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pSideMenu.Location = new System.Drawing.Point(0, 0);
            this.pSideMenu.Name = "pSideMenu";
            this.pSideMenu.Size = new System.Drawing.Size(250, 611);
            this.pSideMenu.TabIndex = 10;
            // 
            // bManageFeedback
            // 
            this.bManageFeedback.Dock = System.Windows.Forms.DockStyle.Top;
            this.bManageFeedback.Location = new System.Drawing.Point(0, 120);
            this.bManageFeedback.Name = "bManageFeedback";
            this.bManageFeedback.Size = new System.Drawing.Size(250, 45);
            this.bManageFeedback.TabIndex = 12;
            this.bManageFeedback.Text = "Manage Feedback";
            this.bManageFeedback.UseVisualStyleBackColor = true;
            this.bManageFeedback.Click += new System.EventHandler(this.bManageFeedback_Click);
            // 
            // bManageCodes
            // 
            this.bManageCodes.Dock = System.Windows.Forms.DockStyle.Top;
            this.bManageCodes.Location = new System.Drawing.Point(0, 75);
            this.bManageCodes.Name = "bManageCodes";
            this.bManageCodes.Size = new System.Drawing.Size(250, 45);
            this.bManageCodes.TabIndex = 11;
            this.bManageCodes.Text = "Manage Codes";
            this.bManageCodes.UseVisualStyleBackColor = true;
            this.bManageCodes.Click += new System.EventHandler(this.bManageCodes_Click);
            // 
            // pHeader
            // 
            this.pHeader.Controls.Add(this.lbMenu);
            this.pHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHeader.Location = new System.Drawing.Point(0, 0);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(250, 75);
            this.pHeader.TabIndex = 0;
            // 
            // pChildForm
            // 
            this.pChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pChildForm.Location = new System.Drawing.Point(250, 0);
            this.pChildForm.Name = "pChildForm";
            this.pChildForm.Size = new System.Drawing.Size(830, 611);
            this.pChildForm.TabIndex = 11;
            this.pChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.pChildForm_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 571);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Note this is a subset of the full system";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 611);
            this.Controls.Add(this.pChildForm);
            this.Controls.Add(this.pSideMenu);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.pSideMenu.ResumeLayout(false);
            this.pSideMenu.PerformLayout();
            this.pHeader.ResumeLayout(false);
            this.pHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbMenu;
        private System.Windows.Forms.Panel pSideMenu;
        private System.Windows.Forms.Panel pHeader;
        private System.Windows.Forms.FlowLayoutPanel pChildForm;
        private System.Windows.Forms.Button bManageFeedback;
        private System.Windows.Forms.Button bManageCodes;
        private System.Windows.Forms.Label label1;
    }
}

