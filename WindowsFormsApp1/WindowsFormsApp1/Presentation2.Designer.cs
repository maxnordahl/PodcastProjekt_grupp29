namespace WindowsFormsApp1
{
    partial class Presentation2
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
            this.txtBoxPodName = new System.Windows.Forms.TextBox();
            this.lblPodName = new System.Windows.Forms.Label();
            this.lblPodCate = new System.Windows.Forms.Label();
            this.lblPodUpdate = new System.Windows.Forms.Label();
            this.cbBoxPodUpdate = new System.Windows.Forms.ComboBox();
            this.cbBoxPodCate = new System.Windows.Forms.ComboBox();
            this.btnPren = new System.Windows.Forms.Button();
            this.txtBoxURL = new System.Windows.Forms.TextBox();
            this.lblURL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxPodName
            // 
            this.txtBoxPodName.Location = new System.Drawing.Point(194, 118);
            this.txtBoxPodName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxPodName.Name = "txtBoxPodName";
            this.txtBoxPodName.Size = new System.Drawing.Size(180, 26);
            this.txtBoxPodName.TabIndex = 0;
            // 
            // lblPodName
            // 
            this.lblPodName.AutoSize = true;
            this.lblPodName.Location = new System.Drawing.Point(48, 123);
            this.lblPodName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPodName.Name = "lblPodName";
            this.lblPodName.Size = new System.Drawing.Size(134, 20);
            this.lblPodName.TabIndex = 1;
            this.lblPodName.Text = "Namnge podcast:";
            // 
            // lblPodCate
            // 
            this.lblPodCate.AutoSize = true;
            this.lblPodCate.Location = new System.Drawing.Point(111, 198);
            this.lblPodCate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPodCate.Name = "lblPodCate";
            this.lblPodCate.Size = new System.Drawing.Size(72, 20);
            this.lblPodCate.TabIndex = 2;
            this.lblPodCate.Text = "Kategori:";
            // 
            // lblPodUpdate
            // 
            this.lblPodUpdate.AutoSize = true;
            this.lblPodUpdate.Location = new System.Drawing.Point(21, 277);
            this.lblPodUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPodUpdate.Name = "lblPodUpdate";
            this.lblPodUpdate.Size = new System.Drawing.Size(162, 20);
            this.lblPodUpdate.TabIndex = 3;
            this.lblPodUpdate.Text = "Uppdateringsintervall:";
            // 
            // cbBoxPodUpdate
            // 
            this.cbBoxPodUpdate.FormattingEnabled = true;
            this.cbBoxPodUpdate.Location = new System.Drawing.Point(194, 272);
            this.cbBoxPodUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbBoxPodUpdate.Name = "cbBoxPodUpdate";
            this.cbBoxPodUpdate.Size = new System.Drawing.Size(180, 28);
            this.cbBoxPodUpdate.TabIndex = 4;
            // 
            // cbBoxPodCate
            // 
            this.cbBoxPodCate.FormattingEnabled = true;
            this.cbBoxPodCate.Location = new System.Drawing.Point(194, 194);
            this.cbBoxPodCate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbBoxPodCate.Name = "cbBoxPodCate";
            this.cbBoxPodCate.Size = new System.Drawing.Size(180, 28);
            this.cbBoxPodCate.TabIndex = 5;
            // 
            // btnPren
            // 
            this.btnPren.Location = new System.Drawing.Point(483, 194);
            this.btnPren.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPren.Name = "btnPren";
            this.btnPren.Size = new System.Drawing.Size(112, 35);
            this.btnPren.TabIndex = 6;
            this.btnPren.Text = "Prenumerera";
            this.btnPren.UseVisualStyleBackColor = true;
            this.btnPren.Click += new System.EventHandler(this.btnPren_Click);
            // 
            // txtBoxURL
            // 
            this.txtBoxURL.Location = new System.Drawing.Point(194, 46);
            this.txtBoxURL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxURL.Name = "txtBoxURL";
            this.txtBoxURL.Size = new System.Drawing.Size(438, 26);
            this.txtBoxURL.TabIndex = 7;
            this.txtBoxURL.TextChanged += new System.EventHandler(this.txtBoxURL_TextChanged);
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(136, 51);
            this.lblURL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(46, 20);
            this.lblURL.TabIndex = 8;
            this.lblURL.Text = "URL:";
            // 
            // Presentation2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 357);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.txtBoxURL);
            this.Controls.Add(this.btnPren);
            this.Controls.Add(this.cbBoxPodCate);
            this.Controls.Add(this.cbBoxPodUpdate);
            this.Controls.Add(this.lblPodUpdate);
            this.Controls.Add(this.lblPodCate);
            this.Controls.Add(this.lblPodName);
            this.Controls.Add(this.txtBoxPodName);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Presentation2";
            this.Text = "Presentation2";
            this.Load += new System.EventHandler(this.Presentation2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxPodName;
        private System.Windows.Forms.Label lblPodName;
        private System.Windows.Forms.Label lblPodCate;
        private System.Windows.Forms.Label lblPodUpdate;
        private System.Windows.Forms.ComboBox cbBoxPodUpdate;
        private System.Windows.Forms.ComboBox cbBoxPodCate;
        private System.Windows.Forms.Button btnPren;
        internal System.Windows.Forms.TextBox txtBoxURL;
        private System.Windows.Forms.Label lblURL;
    }
}