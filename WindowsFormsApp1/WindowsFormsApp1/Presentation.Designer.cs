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
            this.lstBoxCategories = new System.Windows.Forms.ListBox();
            this.lstBoxPodcast = new System.Windows.Forms.ListBox();
            this.lstBoxEpisode = new System.Windows.Forms.ListBox();
            this.lblCategories = new System.Windows.Forms.Label();
            this.lblPodcast = new System.Windows.Forms.Label();
            this.lblEpisode = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPren
            // 
            this.btnPren.Location = new System.Drawing.Point(103, 10);
            this.btnPren.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnPren.Name = "btnPren";
            this.btnPren.Size = new System.Drawing.Size(107, 40);
            this.btnPren.TabIndex = 0;
            this.btnPren.Text = "Ny prenumeration";
            this.btnPren.UseVisualStyleBackColor = true;
            this.btnPren.Click += new System.EventHandler(this.btnPren_Click);
            // 
            // lstBoxCategories
            // 
            this.lstBoxCategories.FormattingEnabled = true;
            this.lstBoxCategories.Location = new System.Drawing.Point(1, 85);
            this.lstBoxCategories.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstBoxCategories.Name = "lstBoxCategories";
            this.lstBoxCategories.Size = new System.Drawing.Size(145, 251);
            this.lstBoxCategories.TabIndex = 3;
            this.lstBoxCategories.Click += new System.EventHandler(this.lstBoxCategories_Click_1);
            this.lstBoxCategories.SelectedIndexChanged += new System.EventHandler(this.lstBoxCategories_SelectedIndexChanged);
            // 
            // lstBoxPodcast
            // 
            this.lstBoxPodcast.FormattingEnabled = true;
            this.lstBoxPodcast.Location = new System.Drawing.Point(164, 85);
            this.lstBoxPodcast.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstBoxPodcast.Name = "lstBoxPodcast";
            this.lstBoxPodcast.Size = new System.Drawing.Size(228, 251);
            this.lstBoxPodcast.TabIndex = 4;
            this.lstBoxPodcast.Click += new System.EventHandler(this.lstBoxPodcast_click);
            // 
            // lstBoxEpisode
            // 
            this.lstBoxEpisode.FormattingEnabled = true;
            this.lstBoxEpisode.Location = new System.Drawing.Point(410, 85);
            this.lstBoxEpisode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstBoxEpisode.Name = "lstBoxEpisode";
            this.lstBoxEpisode.Size = new System.Drawing.Size(274, 251);
            this.lstBoxEpisode.TabIndex = 5;
            this.lstBoxEpisode.Click += new System.EventHandler(this.lstBoxEpisode_Click);
            this.lstBoxEpisode.SelectedIndexChanged += new System.EventHandler(this.lstBoxEpisode_SelectedIndexChanged);
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Location = new System.Drawing.Point(9, 63);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(55, 13);
            this.lblCategories.TabIndex = 6;
            this.lblCategories.Text = "Kategorier";
            // 
            // lblPodcast
            // 
            this.lblPodcast.AutoSize = true;
            this.lblPodcast.Location = new System.Drawing.Point(173, 63);
            this.lblPodcast.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPodcast.Name = "lblPodcast";
            this.lblPodcast.Size = new System.Drawing.Size(46, 13);
            this.lblPodcast.TabIndex = 7;
            this.lblPodcast.Text = "Podcast";
            // 
            // lblEpisode
            // 
            this.lblEpisode.AutoSize = true;
            this.lblEpisode.Location = new System.Drawing.Point(421, 63);
            this.lblEpisode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEpisode.Name = "lblEpisode";
            this.lblEpisode.Size = new System.Drawing.Size(39, 13);
            this.lblEpisode.TabIndex = 8;
            this.lblEpisode.Text = "Avsnitt";
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(263, 10);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(118, 40);
            this.btnSettings.TabIndex = 9;
            this.btnSettings.Text = "Inställningar";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // Presentation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 373);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.lblEpisode);
            this.Controls.Add(this.lblPodcast);
            this.Controls.Add(this.lblCategories);
            this.Controls.Add(this.lstBoxEpisode);
            this.Controls.Add(this.lstBoxPodcast);
            this.Controls.Add(this.lstBoxCategories);
            this.Controls.Add(this.btnPren);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Presentation";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Presentation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPren;
        private System.Windows.Forms.ListBox lstBoxCategories;
        private System.Windows.Forms.ListBox lstBoxPodcast;
        private System.Windows.Forms.ListBox lstBoxEpisode;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.Label lblPodcast;
        private System.Windows.Forms.Label lblEpisode;
        private System.Windows.Forms.Button btnSettings;
    }
}

