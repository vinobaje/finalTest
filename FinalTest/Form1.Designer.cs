namespace FinalTest
{
    partial class Form1
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
            this.FirstNameText = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.Label();
            this.LastNameText = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.Label();
            this.Generator = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstNameText
            // 
            this.FirstNameText.Location = new System.Drawing.Point(89, 57);
            this.FirstNameText.Name = "FirstNameText";
            this.FirstNameText.Size = new System.Drawing.Size(147, 20);
            this.FirstNameText.TabIndex = 0;
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(23, 60);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(60, 13);
            this.FirstName.TabIndex = 1;
            this.FirstName.Text = "First Name:";
            // 
            // LastNameText
            // 
            this.LastNameText.Location = new System.Drawing.Point(89, 99);
            this.LastNameText.Name = "LastNameText";
            this.LastNameText.Size = new System.Drawing.Size(147, 20);
            this.LastNameText.TabIndex = 0;
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(23, 102);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(61, 13);
            this.LastName.TabIndex = 1;
            this.LastName.Text = "Last Name:";
            // 
            // Generator
            // 
            this.Generator.Location = new System.Drawing.Point(26, 184);
            this.Generator.Name = "Generator";
            this.Generator.Size = new System.Drawing.Size(75, 23);
            this.Generator.TabIndex = 2;
            this.Generator.Text = "Generate";
            this.Generator.UseVisualStyleBackColor = true;
            this.Generator.Click += new System.EventHandler(this.Generator_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 252);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Generator);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.LastNameText);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.FirstNameText);
            this.Name = "Form1";
            this.Text = "Generate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstNameText;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.TextBox LastNameText;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Button Generator;
        private System.Windows.Forms.Button button1;
    }
}

