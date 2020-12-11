namespace ReportGenerate
{
    partial class ManageFeedback
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
            this.lbManageFeedback = new System.Windows.Forms.Label();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.build = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbManageFeedback
            // 
            this.lbManageFeedback.AutoSize = true;
            this.lbManageFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbManageFeedback.Location = new System.Drawing.Point(12, 12);
            this.lbManageFeedback.Name = "lbManageFeedback";
            this.lbManageFeedback.Size = new System.Drawing.Size(191, 25);
            this.lbManageFeedback.TabIndex = 7;
            this.lbManageFeedback.Text = "Manage Feedback";
            this.lbManageFeedback.Click += new System.EventHandler(this.lbManageFeedback_Click);
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(17, 56);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(771, 320);
            this.dgv1.TabIndex = 8;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentClick);
            // 
            // build
            // 
            this.build.Location = new System.Drawing.Point(654, 405);
            this.build.Name = "build";
            this.build.Size = new System.Drawing.Size(134, 23);
            this.build.TabIndex = 9;
            this.build.Text = "Build New Feedback";
            this.build.UseVisualStyleBackColor = true;
            this.build.Click += new System.EventHandler(this.build_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(513, 405);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(108, 23);
            this.edit.TabIndex = 10;
            this.edit.Text = "Edit Record";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(713, 16);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(75, 23);
            this.refresh.TabIndex = 11;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // ManageFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.build);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.lbManageFeedback);
            this.Name = "ManageFeedback";
            this.Text = "Manage Feedback";
            this.Load += new System.EventHandler(this.ManageFeedback_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbManageFeedback;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button build;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button refresh;
    }
}