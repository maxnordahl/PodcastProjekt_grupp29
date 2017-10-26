namespace WindowsFormsApp1
{
    partial class Presentation
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
            this.btnPren = new System.Windows.Forms.Button();
            this.lblURL = new System.Windows.Forms.Label();
            this.txtBoxURL = new System.Windows.Forms.TextBox();
            this.lstBoxCategories = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.lblCategories = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPren
            // 
            this.btnPren.Location = new System.Drawing.Point(640, 85);
            this.btnPren.Name = "btnPren";
            this.btnPren.Size = new System.Drawing.Size(159, 31);
            this.btnPren.TabIndex = 0;
            this.btnPren.Text = "Prenumerera";
            this.btnPren.UseVisualStyleBackColor = true;
            this.btnPren.Click += new System.EventHandler(this.btnPren_Click);
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(112, 89);
            this.lblURL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(46, 20);
            this.lblURL.TabIndex = 1;
            this.lblURL.Text = "URL:";
            // 
            // txtBoxURL
            // 
            this.txtBoxURL.Location = new System.Drawing.Point(170, 85);
            this.txtBoxURL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxURL.Name = "txtBoxURL";
            this.txtBoxURL.Size = new System.Drawing.Size(438, 26);
            this.txtBoxURL.TabIndex = 2;
            // 
            // lstBoxCategories
            // 
            this.lstBoxCategories.FormattingEnabled = true;
            this.lstBoxCategories.ItemHeight = 20;
            this.lstBoxCategories.Location = new System.Drawing.Point(81, 237);
            this.lstBoxCategories.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstBoxCategories.Name = "lstBoxCategories";
            this.lstBoxCategories.Size = new System.Drawing.Size(340, 304);
            this.lstBoxCategories.TabIndex = 3;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(489, 237);
            this.listBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(340, 304);
            this.listBox2.TabIndex = 4;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 20;
            this.listBox3.Location = new System.Drawing.Point(908, 237);
            this.listBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(340, 304);
            this.listBox3.TabIndex = 5;
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Location = new System.Drawing.Point(76, 212);
            this.lblCategories.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(82, 20);
            this.lblCategories.TabIndex = 6;
            this.lblCategories.Text = "Kategorier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(484, 212);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Podcast";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(903, 212);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Avsnitt";
            // 
            // Presentation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 795);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCategories);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.lstBoxCategories);
            this.Controls.Add(this.txtBoxURL);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.btnPren);
            this.Name = "Presentation";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Presentation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPren;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.TextBox txtBoxURL;
        private System.Windows.Forms.ListBox lstBoxCategories;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

