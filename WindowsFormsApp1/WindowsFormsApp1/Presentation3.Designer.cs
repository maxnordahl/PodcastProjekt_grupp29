namespace WindowsFormsApp1
{
    partial class Presentation3
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
            this.cbBoxCate = new System.Windows.Forms.ComboBox();
            this.lblChangeCate = new System.Windows.Forms.Label();
            this.txtBoxNewName = new System.Windows.Forms.TextBox();
            this.btnChangeNameCate = new System.Windows.Forms.Button();
            this.lblNewName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbBoxCate
            // 
            this.cbBoxCate.FormattingEnabled = true;
            this.cbBoxCate.Location = new System.Drawing.Point(53, 73);
            this.cbBoxCate.Name = "cbBoxCate";
            this.cbBoxCate.Size = new System.Drawing.Size(121, 21);
            this.cbBoxCate.TabIndex = 0;
            this.cbBoxCate.SelectedIndexChanged += new System.EventHandler(this.cbBoxCate_SelectedIndexChanged);
            // 
            // lblChangeCate
            // 
            this.lblChangeCate.AutoSize = true;
            this.lblChangeCate.Location = new System.Drawing.Point(90, 57);
            this.lblChangeCate.Name = "lblChangeCate";
            this.lblChangeCate.Size = new System.Drawing.Size(49, 13);
            this.lblChangeCate.TabIndex = 1;
            this.lblChangeCate.Text = "Kategori:";
            // 
            // txtBoxNewName
            // 
            this.txtBoxNewName.Location = new System.Drawing.Point(53, 175);
            this.txtBoxNewName.Name = "txtBoxNewName";
            this.txtBoxNewName.Size = new System.Drawing.Size(121, 20);
            this.txtBoxNewName.TabIndex = 2;
            // 
            // btnChangeNameCate
            // 
            this.btnChangeNameCate.Location = new System.Drawing.Point(121, 113);
            this.btnChangeNameCate.Name = "btnChangeNameCate";
            this.btnChangeNameCate.Size = new System.Drawing.Size(75, 23);
            this.btnChangeNameCate.TabIndex = 4;
            this.btnChangeNameCate.Text = "Ändra namn:";
            this.btnChangeNameCate.UseVisualStyleBackColor = true;
            // 
            // lblNewName
            // 
            this.lblNewName.AutoSize = true;
            this.lblNewName.Location = new System.Drawing.Point(81, 159);
            this.lblNewName.Name = "lblNewName";
            this.lblNewName.Size = new System.Drawing.Size(58, 13);
            this.lblNewName.TabIndex = 5;
            this.lblNewName.Text = "Nytt namn:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Presentation3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 347);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblNewName);
            this.Controls.Add(this.btnChangeNameCate);
            this.Controls.Add(this.txtBoxNewName);
            this.Controls.Add(this.lblChangeCate);
            this.Controls.Add(this.cbBoxCate);
            this.Name = "Presentation3";
            this.Text = "Presentation3";
            this.Load += new System.EventHandler(this.Presentation3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbBoxCate;
        private System.Windows.Forms.Label lblChangeCate;
        private System.Windows.Forms.TextBox txtBoxNewName;
        private System.Windows.Forms.Button btnChangeNameCate;
        private System.Windows.Forms.Label lblNewName;
        private System.Windows.Forms.Button button1;
    }
}