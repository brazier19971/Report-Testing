namespace ReportGenerate
{
    partial class EditCodes
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
            this.bodyLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.codeLabel = new System.Windows.Forms.Label();
            this.codeSelector = new System.Windows.Forms.ComboBox();
            this.codeBody = new System.Windows.Forms.RichTextBox();
            this.codeTitle = new System.Windows.Forms.TextBox();
            this.saveUpdate = new System.Windows.Forms.Button();
            this.idBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bodyLabel
            // 
            this.bodyLabel.AutoSize = true;
            this.bodyLabel.Location = new System.Drawing.Point(254, 93);
            this.bodyLabel.Name = "bodyLabel";
            this.bodyLabel.Size = new System.Drawing.Size(59, 13);
            this.bodyLabel.TabIndex = 14;
            this.bodyLabel.Text = "Code Body";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(25, 93);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(55, 13);
            this.titleLabel.TabIndex = 13;
            this.titleLabel.Text = "Code Title";
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.Location = new System.Drawing.Point(22, 25);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(120, 13);
            this.codeLabel.TabIndex = 12;
            this.codeLabel.Text = "Choose a Code Number";
            // 
            // codeSelector
            // 
            this.codeSelector.FormattingEnabled = true;
            this.codeSelector.Location = new System.Drawing.Point(172, 22);
            this.codeSelector.Name = "codeSelector";
            this.codeSelector.Size = new System.Drawing.Size(297, 21);
            this.codeSelector.TabIndex = 11;
            this.codeSelector.SelectedIndexChanged += new System.EventHandler(this.codeSelector_SelectedIndexChanged);
            // 
            // codeBody
            // 
            this.codeBody.Location = new System.Drawing.Point(257, 112);
            this.codeBody.Name = "codeBody";
            this.codeBody.ShortcutsEnabled = false;
            this.codeBody.Size = new System.Drawing.Size(527, 168);
            this.codeBody.TabIndex = 10;
            this.codeBody.Text = "";
            // 
            // codeTitle
            // 
            this.codeTitle.Location = new System.Drawing.Point(25, 112);
            this.codeTitle.Name = "codeTitle";
            this.codeTitle.Size = new System.Drawing.Size(211, 20);
            this.codeTitle.TabIndex = 9;
            // 
            // saveUpdate
            // 
            this.saveUpdate.Location = new System.Drawing.Point(630, 301);
            this.saveUpdate.Name = "saveUpdate";
            this.saveUpdate.Size = new System.Drawing.Size(154, 23);
            this.saveUpdate.TabIndex = 8;
            this.saveUpdate.Text = "Save and Update";
            this.saveUpdate.UseVisualStyleBackColor = true;
            this.saveUpdate.Click += new System.EventHandler(this.saveUpdate_Click);
            // 
            // idBox
            // 
            this.idBox.Enabled = false;
            this.idBox.Location = new System.Drawing.Point(475, 23);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(64, 20);
            this.idBox.TabIndex = 15;
            // 
            // EditCodes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 360);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.bodyLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.codeLabel);
            this.Controls.Add(this.codeSelector);
            this.Controls.Add(this.codeBody);
            this.Controls.Add(this.codeTitle);
            this.Controls.Add(this.saveUpdate);
            this.Name = "EditCodes";
            this.Text = "Edit Codes";
            this.Load += new System.EventHandler(this.EditCodes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bodyLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label codeLabel;
        private System.Windows.Forms.ComboBox codeSelector;
        private System.Windows.Forms.RichTextBox codeBody;
        private System.Windows.Forms.TextBox codeTitle;
        private System.Windows.Forms.Button saveUpdate;
        private System.Windows.Forms.TextBox idBox;
    }
}