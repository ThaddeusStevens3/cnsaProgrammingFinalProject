namespace DoctorXYZ
{
    partial class frmPrescriptions
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
            this.lblTitlePrescription = new System.Windows.Forms.Label();
            this.pnlHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHome
            // 
            this.pnlHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(240)))), ((int)(((byte)(194)))));
            this.pnlHome.Controls.Add(this.lblTitlePrescription);
            this.pnlHome.Location = new System.Drawing.Point(125, 65);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(551, 320);
            this.pnlHome.TabIndex = 3;
            // 
            // lblTitlePrescription
            // 
            this.lblTitlePrescription.AutoSize = true;
            this.lblTitlePrescription.BackColor = System.Drawing.Color.Transparent;
            this.lblTitlePrescription.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitlePrescription.Location = new System.Drawing.Point(237, 41);
            this.lblTitlePrescription.Name = "lblTitlePrescription";
            this.lblTitlePrescription.Size = new System.Drawing.Size(67, 13);
            this.lblTitlePrescription.TabIndex = 2;
            this.lblTitlePrescription.Text = "Prescriptions";
            // 
            // frmPrescriptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlHome);
            this.Name = "frmPrescriptions";
            this.Text = "frmPrescriptions";
            this.pnlHome.ResumeLayout(false);
            this.pnlHome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.Label lblTitlePrescription;
    }
}