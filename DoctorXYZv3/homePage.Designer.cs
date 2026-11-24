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
            this.components = new System.ComponentModel.Container();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnRefills = new System.Windows.Forms.Button();
            this.btnToPrescriptions = new System.Windows.Forms.Button();
            this.btnToPatients = new System.Windows.Forms.Button();
            this.lblTitleHome = new System.Windows.Forms.Label();
            this.mnuHome = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuContextExit = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlHome.SuspendLayout();
            this.mnuHome.SuspendLayout();
            this.mnuContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHome
            // 
            this.pnlHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(240)))), ((int)(((byte)(194)))));
            this.pnlHome.Controls.Add(this.btnSettings);
            this.pnlHome.Controls.Add(this.btnRefills);
            this.pnlHome.Controls.Add(this.btnToPrescriptions);
            this.pnlHome.Controls.Add(this.btnToPatients);
            this.pnlHome.Controls.Add(this.lblTitleHome);
            this.pnlHome.Controls.Add(this.mnuHome);
            this.pnlHome.Location = new System.Drawing.Point(125, 65);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(551, 320);
            this.pnlHome.TabIndex = 1;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Indigo;
            this.btnSettings.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSettings.Location = new System.Drawing.Point(451, 276);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(73, 31);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            // 
            // btnRefills
            // 
            this.btnRefills.BackColor = System.Drawing.Color.Indigo;
            this.btnRefills.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefills.Location = new System.Drawing.Point(325, 112);
            this.btnRefills.Name = "btnRefills";
            this.btnRefills.Size = new System.Drawing.Size(94, 86);
            this.btnRefills.TabIndex = 3;
            this.btnRefills.Text = "Refills";
            this.btnRefills.UseVisualStyleBackColor = false;
            // 
            // btnToPrescriptions
            // 
            this.btnToPrescriptions.BackColor = System.Drawing.Color.Indigo;
            this.btnToPrescriptions.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnToPrescriptions.Location = new System.Drawing.Point(225, 112);
            this.btnToPrescriptions.Name = "btnToPrescriptions";
            this.btnToPrescriptions.Size = new System.Drawing.Size(94, 86);
            this.btnToPrescriptions.TabIndex = 2;
            this.btnToPrescriptions.Text = "Prescriptions";
            this.btnToPrescriptions.UseVisualStyleBackColor = false;
            // 
            // btnToPatients
            // 
            this.btnToPatients.BackColor = System.Drawing.Color.Indigo;
            this.btnToPatients.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnToPatients.Location = new System.Drawing.Point(125, 112);
            this.btnToPatients.Name = "btnToPatients";
            this.btnToPatients.Size = new System.Drawing.Size(94, 86);
            this.btnToPatients.TabIndex = 1;
            this.btnToPatients.Text = "Patients";
            this.btnToPatients.UseVisualStyleBackColor = false;
            this.btnToPatients.Click += new System.EventHandler(this.btnToPatients_Click);
            // 
            // lblTitleHome
            // 
            this.lblTitleHome.AutoSize = true;
            this.lblTitleHome.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleHome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitleHome.Location = new System.Drawing.Point(244, 58);
            this.lblTitleHome.Name = "lblTitleHome";
            this.lblTitleHome.Size = new System.Drawing.Size(52, 13);
            this.lblTitleHome.TabIndex = 0;
            this.lblTitleHome.Text = "Louis MD";
            this.lblTitleHome.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // mnuHome
            // 
            this.mnuHome.BackColor = System.Drawing.Color.Indigo;
            this.mnuHome.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.mnuHome.Location = new System.Drawing.Point(0, 0);
            this.mnuHome.Name = "mnuHome";
            this.mnuHome.Size = new System.Drawing.Size(551, 24);
            this.mnuHome.TabIndex = 5;
            this.mnuHome.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileExit});
            this.mnuFile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(180, 22);
            this.mnuFileExit.Text = "&Exit";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // mnuContext
            // 
            this.mnuContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuContextExit});
            this.mnuContext.Name = "mnuContext";
            this.mnuContext.Size = new System.Drawing.Size(94, 26);
            // 
            // mnuContextExit
            // 
            this.mnuContextExit.Name = "mnuContextExit";
            this.mnuContextExit.Size = new System.Drawing.Size(93, 22);
            this.mnuContextExit.Text = "Exit";
            this.mnuContextExit.Click += new System.EventHandler(this.mnuContextExit_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.mnuContext;
            this.Controls.Add(this.pnlHome);
            this.Name = "frmHome";
            this.Text = "frmHome";
            this.pnlHome.ResumeLayout(false);
            this.pnlHome.PerformLayout();
            this.mnuHome.ResumeLayout(false);
            this.mnuHome.PerformLayout();
            this.mnuContext.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnRefills;
        private System.Windows.Forms.Button btnToPrescriptions;
        private System.Windows.Forms.Button btnToPatients;
        private System.Windows.Forms.Label lblTitleHome;
        private System.Windows.Forms.MenuStrip mnuHome;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ContextMenuStrip mnuContext;
        private System.Windows.Forms.ToolStripMenuItem mnuContextExit;
    }
}