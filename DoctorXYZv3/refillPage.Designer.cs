namespace DoctorXYZ
{
    partial class frmRefills
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
            this.btnHomePatient = new System.Windows.Forms.Button();
            this.lblTitleRefill = new System.Windows.Forms.Label();
            this.btnEditRefill = new System.Windows.Forms.Button();
            this.btnAddRefill = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.xYZINCDataSetFinalv2 = new DoctorXYZ.XYZINCDataSetFinalv2();
            this.xYZINCDataSetFinalv2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.xYZINCFINALV3 = new DoctorXYZ.XYZINCFINALV3();
            this.rEFILLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rEFILLTableAdapter = new DoctorXYZ.XYZINCFINALV3TableAdapters.REFILLTableAdapter();
            this.rEFILLIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xYZINCDataSetFinalv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xYZINCDataSetFinalv2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xYZINCFINALV3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEFILLBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHome
            // 
            this.pnlHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(240)))), ((int)(((byte)(194)))));
            this.pnlHome.Controls.Add(this.dataGridView1);
            this.pnlHome.Controls.Add(this.btnHomePatient);
            this.pnlHome.Controls.Add(this.lblTitleRefill);
            this.pnlHome.Controls.Add(this.btnEditRefill);
            this.pnlHome.Controls.Add(this.btnAddRefill);
            this.pnlHome.Location = new System.Drawing.Point(125, 65);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(551, 320);
            this.pnlHome.TabIndex = 3;
            // 
            // btnHomePatient
            // 
            this.btnHomePatient.Location = new System.Drawing.Point(450, 249);
            this.btnHomePatient.Name = "btnHomePatient";
            this.btnHomePatient.Size = new System.Drawing.Size(75, 23);
            this.btnHomePatient.TabIndex = 15;
            this.btnHomePatient.Text = "Home";
            this.btnHomePatient.UseVisualStyleBackColor = true;
            // 
            // lblTitleRefill
            // 
            this.lblTitleRefill.AutoSize = true;
            this.lblTitleRefill.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleRefill.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitleRefill.Location = new System.Drawing.Point(251, 33);
            this.lblTitleRefill.Name = "lblTitleRefill";
            this.lblTitleRefill.Size = new System.Drawing.Size(35, 13);
            this.lblTitleRefill.TabIndex = 2;
            this.lblTitleRefill.Text = "Refills";
            // 
            // btnEditRefill
            // 
            this.btnEditRefill.Location = new System.Drawing.Point(450, 108);
            this.btnEditRefill.Name = "btnEditRefill";
            this.btnEditRefill.Size = new System.Drawing.Size(75, 49);
            this.btnEditRefill.TabIndex = 14;
            this.btnEditRefill.Text = "Edit Refill";
            this.btnEditRefill.UseVisualStyleBackColor = true;
            // 
            // btnAddRefill
            // 
            this.btnAddRefill.Location = new System.Drawing.Point(450, 53);
            this.btnAddRefill.Name = "btnAddRefill";
            this.btnAddRefill.Size = new System.Drawing.Size(75, 49);
            this.btnAddRefill.TabIndex = 13;
            this.btnAddRefill.Text = "Add Refill";
            this.btnAddRefill.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rEFILLIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rEFILLBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(46, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(363, 177);
            this.dataGridView1.TabIndex = 16;
            // 
            // xYZINCDataSetFinalv2
            // 
            this.xYZINCDataSetFinalv2.DataSetName = "XYZINCDataSetFinalv2";
            this.xYZINCDataSetFinalv2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // xYZINCDataSetFinalv2BindingSource
            // 
            this.xYZINCDataSetFinalv2BindingSource.DataSource = this.xYZINCDataSetFinalv2;
            this.xYZINCDataSetFinalv2BindingSource.Position = 0;
            // 
            // xYZINCFINALV3
            // 
            this.xYZINCFINALV3.DataSetName = "XYZINCFINALV3";
            this.xYZINCFINALV3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rEFILLBindingSource
            // 
            this.rEFILLBindingSource.DataMember = "REFILL";
            this.rEFILLBindingSource.DataSource = this.xYZINCFINALV3;
            // 
            // rEFILLTableAdapter
            // 
            this.rEFILLTableAdapter.ClearBeforeFill = true;
            // 
            // rEFILLIDDataGridViewTextBoxColumn
            // 
            this.rEFILLIDDataGridViewTextBoxColumn.DataPropertyName = "REFILL_ID";
            this.rEFILLIDDataGridViewTextBoxColumn.HeaderText = "REFILL_ID";
            this.rEFILLIDDataGridViewTextBoxColumn.Name = "rEFILLIDDataGridViewTextBoxColumn";
            // 
            // frmRefills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlHome);
            this.Name = "frmRefills";
            this.Text = "frmRefills";
            this.Load += new System.EventHandler(this.frmRefills_Load);
            this.pnlHome.ResumeLayout(false);
            this.pnlHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xYZINCDataSetFinalv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xYZINCDataSetFinalv2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xYZINCFINALV3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEFILLBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.Label lblTitleRefill;
        private System.Windows.Forms.Button btnHomePatient;
        private System.Windows.Forms.Button btnEditRefill;
        private System.Windows.Forms.Button btnAddRefill;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource xYZINCDataSetFinalv2BindingSource;
        private XYZINCDataSetFinalv2 xYZINCDataSetFinalv2;
        private XYZINCFINALV3 xYZINCFINALV3;
        private System.Windows.Forms.BindingSource rEFILLBindingSource;
        private XYZINCFINALV3TableAdapters.REFILLTableAdapter rEFILLTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEFILLIDDataGridViewTextBoxColumn;
    }
}