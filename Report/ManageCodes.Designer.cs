namespace ReportGenerate
{
    partial class ManageCodes
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
            this.components = new System.ComponentModel.Container();
            this.dataSet1 = new ReportGenerate.DataSet1();
            this.codesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codesTableAdapter = new ReportGenerate.DataSet1TableAdapters.CodesTableAdapter();
            this.tableAdapterManager = new ReportGenerate.DataSet1TableAdapters.TableAdapterManager();
            this.titleName = new System.Windows.Forms.Label();
            this.codeManageDGV = new System.Windows.Forms.DataGridView();
            this.addCodes = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeManageDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // codesBindingSource
            // 
            this.codesBindingSource.DataMember = "Codes";
            this.codesBindingSource.DataSource = this.dataSet1;
            // 
            // codesTableAdapter
            // 
            this.codesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CodesTableAdapter = this.codesTableAdapter;
            this.tableAdapterManager.UpdateOrder = ReportGenerate.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // titleName
            // 
            this.titleName.AutoSize = true;
            this.titleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleName.Location = new System.Drawing.Point(25, 20);
            this.titleName.Name = "titleName";
            this.titleName.Size = new System.Drawing.Size(139, 24);
            this.titleName.TabIndex = 8;
            this.titleName.Text = "Manage Codes";
            // 
            // codeManageDGV
            // 
            this.codeManageDGV.AllowUserToAddRows = false;
            this.codeManageDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.codeManageDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.codeManageDGV.Location = new System.Drawing.Point(29, 60);
            this.codeManageDGV.Name = "codeManageDGV";
            this.codeManageDGV.Size = new System.Drawing.Size(777, 239);
            this.codeManageDGV.TabIndex = 9;
            this.codeManageDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.codeManageDGV_CellContentClick);
            // 
            // addCodes
            // 
            this.addCodes.Location = new System.Drawing.Point(731, 319);
            this.addCodes.Name = "addCodes";
            this.addCodes.Size = new System.Drawing.Size(75, 23);
            this.addCodes.TabIndex = 10;
            this.addCodes.Text = "Add Code";
            this.addCodes.UseVisualStyleBackColor = true;
            this.addCodes.Click += new System.EventHandler(this.addCodes_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(641, 319);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(84, 23);
            this.editButton.TabIndex = 11;
            this.editButton.Text = "Edit a Code";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(731, 23);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(75, 23);
            this.refresh.TabIndex = 12;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // ManageCodes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 769);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addCodes);
            this.Controls.Add(this.codeManageDGV);
            this.Controls.Add(this.titleName);
            this.Name = "ManageCodes";
            this.Text = "ManageCodes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageCodes_FormClosing);
            this.Load += new System.EventHandler(this.ManageCodes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeManageDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource codesBindingSource;
        private DataSet1TableAdapters.CodesTableAdapter codesTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label titleName;
        private System.Windows.Forms.DataGridView codeManageDGV;
        private System.Windows.Forms.Button addCodes;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button refresh;
    }
}