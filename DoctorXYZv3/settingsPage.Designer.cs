namespace DoctorXYZ
{
    partial class frmSettings
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
            this.pnlHome = new System.Windows.Forms.Panel();
            this.lblTitleSettings = new System.Windows.Forms.Label();
            this.pnlHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHome
            // 
            this.pnlHome.BackColor = System.Drawing.Color.Gray;
            this.pnlHome.Controls.Add(this.lblTitleSettings);
            this.pnlHome.Location = new System.Drawing.Point(125, 65);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(551, 320);
            this.pnlHome.TabIndex = 3;
            // 
            // lblTitleSettings
            // 
            this.lblTitleSettings.AutoSize = true;
            this.lblTitleSettings.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleSettings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitleSettings.Location = new System.Drawing.Point(237, 35);
            this.lblTitleSettings.Name = "lblTitleSettings";
            this.lblTitleSettings.Size = new System.Drawing.Size(45, 13);
            this.lblTitleSettings.TabIndex = 4;
            this.lblTitleSettings.Text = "Settings";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlHome);
            this.Name = "frmSettings";
            this.Text = "frmSettings";
            this.pnlHome.ResumeLayout(false);
            this.pnlHome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.Label lblTitleSettings;
    }
}