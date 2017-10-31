namespace WindowsFormsApp1
{
    partial class Inställningar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inställningar));
            this.btnPren = new System.Windows.Forms.Button();
            this.lstBoxCategories = new System.Windows.Forms.ListBox();
            this.lstBoxPodcast = new System.Windows.Forms.ListBox();
            this.lstBoxEpisode = new System.Windows.Forms.ListBox();
            this.lblCategories = new System.Windows.Forms.Label();
            this.lblPodcast = new System.Windows.Forms.Label();
            this.lblEpisode = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnSettings = new System.Windows.Forms.Button();
            this.lblDownload = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPren
            // 
            this.btnPren.Location = new System.Drawing.Point(266, 63);
            this.btnPren.Name = "btnPren";
            this.btnPren.Size = new System.Drawing.Size(160, 62);
            this.btnPren.TabIndex = 0;
            this.btnPren.Text = "Ny prenumeration";
            this.btnPren.UseVisualStyleBackColor = true;
            this.btnPren.Click += new System.EventHandler(this.btnPren_Click);
            // 
            // lstBoxCategories
            // 
            this.lstBoxCategories.FormattingEnabled = true;
            this.lstBoxCategories.ItemHeight = 20;
            this.lstBoxCategories.Location = new System.Drawing.Point(75, 251);
            this.lstBoxCategories.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstBoxCategories.Name = "lstBoxCategories";
            this.lstBoxCategories.Size = new System.Drawing.Size(216, 384);
            this.lstBoxCategories.TabIndex = 3;
            this.lstBoxCategories.Click += new System.EventHandler(this.lstBoxCategories_Click_1);
            // 
            // lstBoxPodcast
            // 
            this.lstBoxPodcast.FormattingEnabled = true;
            this.lstBoxPodcast.ItemHeight = 20;
            this.lstBoxPodcast.Location = new System.Drawing.Point(432, 251);
            this.lstBoxPodcast.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstBoxPodcast.Name = "lstBoxPodcast";
            this.lstBoxPodcast.Size = new System.Drawing.Size(340, 384);
            this.lstBoxPodcast.TabIndex = 4;
            this.lstBoxPodcast.Click += new System.EventHandler(this.lstBoxPodcast_click);
            // 
            // lstBoxEpisode
            // 
            this.lstBoxEpisode.FormattingEnabled = true;
            this.lstBoxEpisode.ItemHeight = 20;
            this.lstBoxEpisode.Location = new System.Drawing.Point(918, 251);
            this.lstBoxEpisode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstBoxEpisode.Name = "lstBoxEpisode";
            this.lstBoxEpisode.Size = new System.Drawing.Size(409, 384);
            this.lstBoxEpisode.TabIndex = 5;
            this.lstBoxEpisode.DoubleClick += new System.EventHandler(this.lstBoxEpisode_DoubleClick);
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Location = new System.Drawing.Point(146, 202);
            this.lblCategories.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(82, 20);
            this.lblCategories.TabIndex = 6;
            this.lblCategories.Text = "Kategorier";
            // 
            // lblPodcast
            // 
            this.lblPodcast.AutoSize = true;
            this.lblPodcast.Location = new System.Drawing.Point(558, 202);
            this.lblPodcast.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPodcast.Name = "lblPodcast";
            this.lblPodcast.Size = new System.Drawing.Size(67, 20);
            this.lblPodcast.TabIndex = 7;
            this.lblPodcast.Text = "Podcast";
            // 
            // lblEpisode
            // 
            this.lblEpisode.AutoSize = true;
            this.lblEpisode.Location = new System.Drawing.Point(1082, 202);
            this.lblEpisode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEpisode.Name = "lblEpisode";
            this.lblEpisode.Size = new System.Drawing.Size(57, 20);
            this.lblEpisode.TabIndex = 8;
            this.lblEpisode.Text = "Avsnitt";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(918, 14);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(409, 142);
            this.axWindowsMediaPlayer1.TabIndex = 9;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(549, 63);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(160, 62);
            this.btnSettings.TabIndex = 10;
            this.btnSettings.Text = "Inställningar";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_click);
            // 
            // lblDownload
            // 
            this.lblDownload.AutoSize = true;
            this.lblDownload.Location = new System.Drawing.Point(924, 656);
            this.lblDownload.Name = "lblDownload";
            this.lblDownload.Size = new System.Drawing.Size(0, 20);
            this.lblDownload.TabIndex = 11;
            // 
            // Inställningar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1808, 883);
            this.Controls.Add(this.lblDownload);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.lblEpisode);
            this.Controls.Add(this.lblPodcast);
            this.Controls.Add(this.lblCategories);
            this.Controls.Add(this.lstBoxEpisode);
            this.Controls.Add(this.lstBoxPodcast);
            this.Controls.Add(this.lstBoxCategories);
            this.Controls.Add(this.btnPren);
            this.Name = "Inställningar";
            this.Text = "btnSettings";
            this.Load += new System.EventHandler(this.Presentation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
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
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label lblDownload;
    }
}

