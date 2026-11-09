namespace DoctorXYZ
{
    partial class frmHome
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnToPatients = new System.Windows.Forms.Button();
            this.btnToPrescriptions = new System.Windows.Forms.Button();
            this.btnRefills = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.pnlHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHome
            // 
            this.pnlHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(240)))), ((int)(((byte)(194)))));
            this.pnlHome.Controls.Add(this.btnSettings);
            this.pnlHome.Controls.Add(this.btnRefills);
            this.pnlHome.Controls.Add(this.btnToPrescriptions);
            this.pnlHome.Controls.Add(this.btnToPatients);
            this.pnlHome.Controls.Add(this.lblTitle);
            this.pnlHome.Location = new System.Drawing.Point(171, 91);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(551, 320);
            this.pnlHome.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(244, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(49, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "XYZ Inc.";
            // 
            // btnToPatients
            // 
            this.btnToPatients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(185)))), ((int)(((byte)(168)))));
            this.btnToPatients.ForeColor = System.Drawing.Color.Black;
            this.btnToPatients.Location = new System.Drawing.Point(125, 112);
            this.btnToPatients.Name = "btnToPatients";
            this.btnToPatients.Size = new System.Drawing.Size(94, 86);
            this.btnToPatients.TabIndex = 1;
            this.btnToPatients.Text = "Patients";
            this.btnToPatients.UseVisualStyleBackColor = false;
            // 
            // btnToPrescriptions
            // 
            this.btnToPrescriptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(185)))), ((int)(((byte)(168)))));
            this.btnToPrescriptions.ForeColor = System.Drawing.Color.Black;
            this.btnToPrescriptions.Location = new System.Drawing.Point(225, 112);
            this.btnToPrescriptions.Name = "btnToPrescriptions";
            this.btnToPrescriptions.Size = new System.Drawing.Size(94, 86);
            this.btnToPrescriptions.TabIndex = 2;
            this.btnToPrescriptions.Text = "Prescriptions";
            this.btnToPrescriptions.UseVisualStyleBackColor = false;
            // 
            // btnRefills
            // 
            this.btnRefills.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(185)))), ((int)(((byte)(168)))));
            this.btnRefills.ForeColor = System.Drawing.Color.Black;
            this.btnRefills.Location = new System.Drawing.Point(325, 112);
            this.btnRefills.Name = "btnRefills";
            this.btnRefills.Size = new System.Drawing.Size(94, 86);
            this.btnRefills.TabIndex = 3;
            this.btnRefills.Text = "Refills";
            this.btnRefills.UseVisualStyleBackColor = false;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(185)))), ((int)(((byte)(168)))));
            this.btnSettings.ForeColor = System.Drawing.Color.Black;
            this.btnSettings.Location = new System.Drawing.Point(451, 276);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(73, 31);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 542);
            this.Controls.Add(this.pnlHome);
            this.Name = "frmHome";
            this.Text = "Home Page";
            this.pnlHome.ResumeLayout(false);
            this.pnlHome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnRefills;
        private System.Windows.Forms.Button btnToPrescriptions;
        private System.Windows.Forms.Button btnToPatients;
    }
}

