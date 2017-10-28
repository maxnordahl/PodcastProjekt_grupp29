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
            this.lblCate = new System.Windows.Forms.Label();
            this.btnRemoveCate = new System.Windows.Forms.Button();
            this.btnChangeCateName = new System.Windows.Forms.Button();
            this.txtBoxNewName = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmBoxCateName = new System.Windows.Forms.ComboBox();
            this.lblNewName = new System.Windows.Forms.Label();
            this.txtBoxNewCateName = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnChangeName = new System.Windows.Forms.Button();
            this.lblPod = new System.Windows.Forms.Label();
            this.cmBoxPods = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblCate
            // 
            this.lblCate.AutoSize = true;
            this.lblCate.Location = new System.Drawing.Point(130, 103);
            this.lblCate.Name = "lblCate";
            this.lblCate.Size = new System.Drawing.Size(72, 20);
            this.lblCate.TabIndex = 0;
            this.lblCate.Text = "Kategori:";
            // 
            // btnRemoveCate
            // 
            this.btnRemoveCate.Location = new System.Drawing.Point(47, 178);
            this.btnRemoveCate.Name = "btnRemoveCate";
            this.btnRemoveCate.Size = new System.Drawing.Size(75, 33);
            this.btnRemoveCate.TabIndex = 2;
            this.btnRemoveCate.Text = "Ta bort";
            this.btnRemoveCate.UseVisualStyleBackColor = true;
            // 
            // btnChangeCateName
            // 
            this.btnChangeCateName.Location = new System.Drawing.Point(148, 178);
            this.btnChangeCateName.Name = "btnChangeCateName";
            this.btnChangeCateName.Size = new System.Drawing.Size(129, 33);
            this.btnChangeCateName.TabIndex = 3;
            this.btnChangeCateName.Text = "Ändra namn";
            this.btnChangeCateName.UseVisualStyleBackColor = true;
            // 
            // txtBoxNewName
            // 
            this.txtBoxNewName.Location = new System.Drawing.Point(107, 257);
            this.txtBoxNewName.Name = "txtBoxNewName";
            this.txtBoxNewName.Size = new System.Drawing.Size(121, 26);
            this.txtBoxNewName.TabIndex = 4;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(130, 103);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(72, 20);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Kategori:";
            // 
            // cmBoxCateName
            // 
            this.cmBoxCateName.FormattingEnabled = true;
            this.cmBoxCateName.Location = new System.Drawing.Point(107, 126);
            this.cmBoxCateName.Name = "cmBoxCateName";
            this.cmBoxCateName.Size = new System.Drawing.Size(121, 28);
            this.cmBoxCateName.TabIndex = 5;
            // 
            // lblNewName
            // 
            this.lblNewName.AutoSize = true;
            this.lblNewName.Location = new System.Drawing.Point(130, 234);
            this.lblNewName.Name = "lblNewName";
            this.lblNewName.Size = new System.Drawing.Size(85, 20);
            this.lblNewName.TabIndex = 6;
            this.lblNewName.Text = "Nytt namn:";
            // 
            // txtBoxNewCateName
            // 
            this.txtBoxNewCateName.Location = new System.Drawing.Point(107, 257);
            this.txtBoxNewCateName.Name = "txtBoxNewCateName";
            this.txtBoxNewCateName.Size = new System.Drawing.Size(121, 26);
            this.txtBoxNewCateName.TabIndex = 4;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(76, 178);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Ta bort";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnChangeName
            // 
            this.btnChangeName.Location = new System.Drawing.Point(184, 178);
            this.btnChangeName.Name = "btnChangeName";
            this.btnChangeName.Size = new System.Drawing.Size(75, 33);
            this.btnChangeName.TabIndex = 3;
            this.btnChangeName.Text = "Ändra namn";
            this.btnChangeName.UseVisualStyleBackColor = true;
            // 
            // lblPod
            // 
            this.lblPod.AutoSize = true;
            this.lblPod.Location = new System.Drawing.Point(490, 103);
            this.lblPod.Name = "lblPod";
            this.lblPod.Size = new System.Drawing.Size(71, 20);
            this.lblPod.TabIndex = 7;
            this.lblPod.Text = "Podcast:";
            // 
            // cmBoxPods
            // 
            this.cmBoxPods.FormattingEnabled = true;
            this.cmBoxPods.Location = new System.Drawing.Point(465, 126);
            this.cmBoxPods.Name = "cmBoxPods";
            this.cmBoxPods.Size = new System.Drawing.Size(121, 28);
            this.cmBoxPods.TabIndex = 8;
            // 
            // Presentation3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 548);
            this.Controls.Add(this.cmBoxPods);
            this.Controls.Add(this.lblPod);
            this.Controls.Add(this.lblNewName);
            this.Controls.Add(this.cmBoxCateName);
            this.Controls.Add(this.txtBoxNewName);
            this.Controls.Add(this.btnChangeCateName);
            this.Controls.Add(this.btnRemoveCate);
            this.Controls.Add(this.lblCate);
            this.Name = "Presentation3";
            this.Text = "Presentation3";
            this.Load += new System.EventHandler(this.Presentation3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblCate;
        private System.Windows.Forms.Button btnRemoveCate;
        private System.Windows.Forms.Button btnChangeCateName;
        private System.Windows.Forms.TextBox txtBoxNewName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmBoxCateName;
        private System.Windows.Forms.Label lblNewName;
        private System.Windows.Forms.TextBox txtBoxNewCateName;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnChangeName;
        private System.Windows.Forms.Label lblPod;
        private System.Windows.Forms.ComboBox cmBoxPods;
    }
}