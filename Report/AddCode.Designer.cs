namespace ReportGenerate
{
    partial class AddCode
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
            this.save = new System.Windows.Forms.Button();
            this.codeTitle = new System.Windows.Forms.TextBox();
            this.codeBody = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.body = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(602, 332);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(162, 23);
            this.save.TabIndex = 0;
            this.save.Text = "Add";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // codeTitle
            // 
            this.codeTitle.Location = new System.Drawing.Point(46, 86);
            this.codeTitle.Name = "codeTitle";
            this.codeTitle.Size = new System.Drawing.Size(718, 20);
            this.codeTitle.TabIndex = 1;
            // 
            // codeBody
            // 
            this.codeBody.Location = new System.Drawing.Point(46, 143);
            this.codeBody.Name = "codeBody";
            this.codeBody.Size = new System.Drawing.Size(718, 167);
            this.codeBody.TabIndex = 2;
            this.codeBody.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Add a New Code";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(43, 58);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(60, 13);
            this.name.TabIndex = 7;
            this.name.Text = "New Name";
            // 
            // body
            // 
            this.body.AutoSize = true;
            this.body.Location = new System.Drawing.Point(47, 127);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(56, 13);
            this.body.TabIndex = 8;
            this.body.Text = "New Body";
            // 
            // AddCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 372);
            this.Controls.Add(this.body);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.codeBody);
            this.Controls.Add(this.codeTitle);
            this.Controls.Add(this.save);
            this.Name = "AddCode";
            this.Text = "AddCode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox codeTitle;
        private System.Windows.Forms.RichTextBox codeBody;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label body;
    }
}