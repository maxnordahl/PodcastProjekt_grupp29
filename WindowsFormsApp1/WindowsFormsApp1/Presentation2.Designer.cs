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
            this.txtBoxPodName.Location = new System.Drawing.Point(129, 77);
            this.txtBoxPodName.Name = "txtBoxPodName";
            this.txtBoxPodName.Size = new System.Drawing.Size(121, 20);
            this.txtBoxPodName.TabIndex = 0;
            // 
            // lblPodName
            // 
            this.lblPodName.AutoSize = true;
            this.lblPodName.Location = new System.Drawing.Point(32, 80);
            this.lblPodName.Name = "lblPodName";
            this.lblPodName.Size = new System.Drawing.Size(91, 13);
            this.lblPodName.TabIndex = 1;
            this.lblPodName.Text = "Namnge podcast:";
            // 
            // lblPodCate
            // 
            this.lblPodCate.AutoSize = true;
            this.lblPodCate.Location = new System.Drawing.Point(74, 129);
            this.lblPodCate.Name = "lblPodCate";
            this.lblPodCate.Size = new System.Drawing.Size(49, 13);
            this.lblPodCate.TabIndex = 2;
            this.lblPodCate.Text = "Kategori:";
            // 
            // lblPodUpdate
            // 
            this.lblPodUpdate.AutoSize = true;
            this.lblPodUpdate.Location = new System.Drawing.Point(14, 180);
            this.lblPodUpdate.Name = "lblPodUpdate";
            this.lblPodUpdate.Size = new System.Drawing.Size(109, 13);
            this.lblPodUpdate.TabIndex = 3;
            this.lblPodUpdate.Text = "Uppdateringsintervall:";
            // 
            // cbBoxPodUpdate
            // 
            this.cbBoxPodUpdate.FormattingEnabled = true;
            this.cbBoxPodUpdate.Items.AddRange(new object[] {
            "Varje minut",
            "Varje timme",
            "Varje dag"});
            this.cbBoxPodUpdate.Location = new System.Drawing.Point(129, 177);
            this.cbBoxPodUpdate.Name = "cbBoxPodUpdate";
            this.cbBoxPodUpdate.Size = new System.Drawing.Size(121, 21);
            this.cbBoxPodUpdate.TabIndex = 4;
            // 
            // cbBoxPodCate
            // 
            this.cbBoxPodCate.FormattingEnabled = true;
            this.cbBoxPodCate.Location = new System.Drawing.Point(129, 126);
            this.cbBoxPodCate.Name = "cbBoxPodCate";
            this.cbBoxPodCate.Size = new System.Drawing.Size(121, 21);
            this.cbBoxPodCate.TabIndex = 5;
            // 
            // btnPren
            // 
            this.btnPren.Location = new System.Drawing.Point(322, 126);
            this.btnPren.Name = "btnPren";
            this.btnPren.Size = new System.Drawing.Size(75, 23);
            this.btnPren.TabIndex = 6;
            this.btnPren.Text = "Prenumerera";
            this.btnPren.UseVisualStyleBackColor = true;
            this.btnPren.Click += new System.EventHandler(this.btnPren_Click);
            // 
            // txtBoxURL
            // 
            this.txtBoxURL.Location = new System.Drawing.Point(129, 30);
            this.txtBoxURL.Name = "txtBoxURL";
            this.txtBoxURL.Size = new System.Drawing.Size(293, 20);
            this.txtBoxURL.TabIndex = 7;
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(91, 33);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(32, 13);
            this.lblURL.TabIndex = 8;
            this.lblURL.Text = "URL:";
            // 
            // Presentation2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 232);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.txtBoxURL);
            this.Controls.Add(this.btnPren);
            this.Controls.Add(this.cbBoxPodCate);
            this.Controls.Add(this.cbBoxPodUpdate);
            this.Controls.Add(this.lblPodUpdate);
            this.Controls.Add(this.lblPodCate);
            this.Controls.Add(this.lblPodName);
            this.Controls.Add(this.txtBoxPodName);
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