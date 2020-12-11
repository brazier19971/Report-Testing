namespace ReportGenerate
{
    partial class BuildFeedback
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.apName = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.apMail = new System.Windows.Forms.TextBox();
            this.apTemplate = new System.Windows.Forms.ComboBox();
            this.templateLabel = new System.Windows.Forms.Label();
            this.apFreeText = new System.Windows.Forms.RichTextBox();
            this.save = new System.Windows.Forms.Button();
            this.template = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.freetextLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(22, 25);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(82, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Applicant Name";
            // 
            // apName
            // 
            this.apName.Location = new System.Drawing.Point(25, 50);
            this.apName.Name = "apName";
            this.apName.Size = new System.Drawing.Size(216, 20);
            this.apName.TabIndex = 1;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(257, 25);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(79, 13);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "Applicant Email";
            // 
            // apMail
            // 
            this.apMail.Location = new System.Drawing.Point(260, 50);
            this.apMail.Name = "apMail";
            this.apMail.Size = new System.Drawing.Size(216, 20);
            this.apMail.TabIndex = 3;
            // 
            // apTemplate
            // 
            this.apTemplate.FormattingEnabled = true;
            this.apTemplate.Location = new System.Drawing.Point(492, 49);
            this.apTemplate.Name = "apTemplate";
            this.apTemplate.Size = new System.Drawing.Size(216, 21);
            this.apTemplate.TabIndex = 4;
            this.apTemplate.SelectedIndexChanged += new System.EventHandler(this.apTemplate_SelectedIndexChanged);
            // 
            // templateLabel
            // 
            this.templateLabel.AutoSize = true;
            this.templateLabel.Location = new System.Drawing.Point(492, 25);
            this.templateLabel.Name = "templateLabel";
            this.templateLabel.Size = new System.Drawing.Size(51, 13);
            this.templateLabel.TabIndex = 5;
            this.templateLabel.Text = "Template";
            // 
            // apFreeText
            // 
            this.apFreeText.Location = new System.Drawing.Point(25, 146);
            this.apFreeText.Name = "apFreeText";
            this.apFreeText.Size = new System.Drawing.Size(683, 327);
            this.apFreeText.TabIndex = 12;
            this.apFreeText.Text = "";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(633, 490);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 13;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // template
            // 
            this.template.Enabled = false;
            this.template.Location = new System.Drawing.Point(492, 77);
            this.template.Name = "template";
            this.template.Size = new System.Drawing.Size(216, 20);
            this.template.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(785, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 447);
            this.panel1.TabIndex = 15;
            // 
            // freetextLabel
            // 
            this.freetextLabel.AutoSize = true;
            this.freetextLabel.Location = new System.Drawing.Point(25, 127);
            this.freetextLabel.Name = "freetextLabel";
            this.freetextLabel.Size = new System.Drawing.Size(45, 13);
            this.freetextLabel.TabIndex = 16;
            this.freetextLabel.Text = "Freetext";
            // 
            // BuildFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 532);
            this.Controls.Add(this.freetextLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.template);
            this.Controls.Add(this.save);
            this.Controls.Add(this.apFreeText);
            this.Controls.Add(this.templateLabel);
            this.Controls.Add(this.apTemplate);
            this.Controls.Add(this.apMail);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.apName);
            this.Controls.Add(this.nameLabel);
            this.Name = "BuildFeedback";
            this.Text = "Build Feedback";
            this.Load += new System.EventHandler(this.buildFeedback_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox apName;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox apMail;
        private System.Windows.Forms.ComboBox apTemplate;
        private System.Windows.Forms.Label templateLabel;
        private System.Windows.Forms.RichTextBox apFreeText;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox template;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label freetextLabel;
    }
}