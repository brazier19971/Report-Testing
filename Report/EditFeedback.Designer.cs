namespace ReportGenerate
{
    partial class EditFeedback
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
            this.templateName = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.template = new System.Windows.Forms.Label();
            this.apTemplate = new System.Windows.Forms.ComboBox();
            this.email = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.apName = new System.Windows.Forms.TextBox();
            this.apMail = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.apFreeText = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // templateName
            // 
            this.templateName.Enabled = false;
            this.templateName.Location = new System.Drawing.Point(527, 126);
            this.templateName.Name = "templateName";
            this.templateName.Size = new System.Drawing.Size(216, 20);
            this.templateName.TabIndex = 29;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(668, 539);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 28;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // template
            // 
            this.template.AutoSize = true;
            this.template.Location = new System.Drawing.Point(527, 74);
            this.template.Name = "template";
            this.template.Size = new System.Drawing.Size(51, 13);
            this.template.TabIndex = 20;
            this.template.Text = "Template";
            // 
            // apTemplate
            // 
            this.apTemplate.FormattingEnabled = true;
            this.apTemplate.Location = new System.Drawing.Point(527, 98);
            this.apTemplate.Name = "apTemplate";
            this.apTemplate.Size = new System.Drawing.Size(216, 21);
            this.apTemplate.TabIndex = 19;
            this.apTemplate.SelectedIndexChanged += new System.EventHandler(this.apTemplate_SelectedIndexChanged);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(292, 74);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(79, 13);
            this.email.TabIndex = 17;
            this.email.Text = "Applicant Email";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(57, 74);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(82, 13);
            this.name.TabIndex = 15;
            this.name.Text = "Applicant Name";
            // 
            // apName
            // 
            this.apName.Location = new System.Drawing.Point(60, 99);
            this.apName.Name = "apName";
            this.apName.Size = new System.Drawing.Size(218, 20);
            this.apName.TabIndex = 30;
            // 
            // apMail
            // 
            this.apMail.Location = new System.Drawing.Point(295, 99);
            this.apMail.Name = "apMail";
            this.apMail.Size = new System.Drawing.Size(226, 20);
            this.apMail.TabIndex = 31;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(785, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 553);
            this.panel1.TabIndex = 32;
            // 
            // apFreeText
            // 
            this.apFreeText.Location = new System.Drawing.Point(60, 204);
            this.apFreeText.Name = "apFreeText";
            this.apFreeText.Size = new System.Drawing.Size(683, 291);
            this.apFreeText.TabIndex = 33;
            this.apFreeText.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Add Freetext";
            // 
            // EditFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 636);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.apFreeText);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.apMail);
            this.Controls.Add(this.apName);
            this.Controls.Add(this.templateName);
            this.Controls.Add(this.save);
            this.Controls.Add(this.template);
            this.Controls.Add(this.apTemplate);
            this.Controls.Add(this.email);
            this.Controls.Add(this.name);
            this.Name = "EditFeedback";
            this.Text = "Edit Feedback";
            this.Load += new System.EventHandler(this.EditFeedback_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox templateName;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label template;
        private System.Windows.Forms.ComboBox apTemplate;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox apName;
        private System.Windows.Forms.TextBox apMail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox apFreeText;
        private System.Windows.Forms.Label label4;
    }
}