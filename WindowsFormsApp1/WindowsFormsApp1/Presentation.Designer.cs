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
            this.SuspendLayout();
            // 
            // btnPren
            // 
            this.btnPren.Location = new System.Drawing.Point(427, 55);
            this.btnPren.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPren.Name = "btnPren";
            this.btnPren.Size = new System.Drawing.Size(106, 20);
            this.btnPren.TabIndex = 0;
            this.btnPren.Text = "Prenumerera";
            this.btnPren.UseVisualStyleBackColor = true;
            this.btnPren.Click += new System.EventHandler(this.btnPren_Click);
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(75, 58);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(32, 13);
            this.lblURL.TabIndex = 1;
            this.lblURL.Text = "URL:";
            // 
            // txtBoxURL
            // 
            this.txtBoxURL.Location = new System.Drawing.Point(113, 55);
            this.txtBoxURL.Name = "txtBoxURL";
            this.txtBoxURL.Size = new System.Drawing.Size(293, 20);
            this.txtBoxURL.TabIndex = 2;
            // 
            // Presentation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 517);
            this.Controls.Add(this.txtBoxURL);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.btnPren);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Presentation";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPren;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.TextBox txtBoxURL;
    }
}

