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
            this.components = new System.ComponentModel.Container();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.lblTitlePrescription = new System.Windows.Forms.Label();
            this.btnHomePatient = new System.Windows.Forms.Button();
            this.btnEditPrescription = new System.Windows.Forms.Button();
            this.btnAddPrescription = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.xYZINCDataSetFinalv2 = new DoctorXYZ.XYZINCDataSetFinalv2();
            this.pRESCRIPTIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRESCRIPTIONTableAdapter = new DoctorXYZ.XYZINCDataSetFinalv2TableAdapters.PRESCRIPTIONTableAdapter();
            this.pRESCRIPTIONIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pATIENTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRESCRIPTIONNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONSUMPTIONMETHODDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEFILLNUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRESCRIPTIONDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xYZINCDataSetFinalv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRESCRIPTIONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHome
            // 
            this.pnlHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(240)))), ((int)(((byte)(194)))));
            this.pnlHome.Controls.Add(this.dataGridView1);
            this.pnlHome.Controls.Add(this.btnHomePatient);
            this.pnlHome.Controls.Add(this.lblTitlePrescription);
            this.pnlHome.Controls.Add(this.btnEditPrescription);
            this.pnlHome.Controls.Add(this.btnAddPrescription);
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
            // btnHomePatient
            // 
            this.btnHomePatient.Location = new System.Drawing.Point(445, 252);
            this.btnHomePatient.Name = "btnHomePatient";
            this.btnHomePatient.Size = new System.Drawing.Size(75, 23);
            this.btnHomePatient.TabIndex = 15;
            this.btnHomePatient.Text = "Home";
            this.btnHomePatient.UseVisualStyleBackColor = true;
            // 
            // btnEditPrescription
            // 
            this.btnEditPrescription.Location = new System.Drawing.Point(445, 111);
            this.btnEditPrescription.Name = "btnEditPrescription";
            this.btnEditPrescription.Size = new System.Drawing.Size(75, 49);
            this.btnEditPrescription.TabIndex = 14;
            this.btnEditPrescription.Text = "Edit Prescription";
            this.btnEditPrescription.UseVisualStyleBackColor = true;
            // 
            // btnAddPrescription
            // 
            this.btnAddPrescription.Location = new System.Drawing.Point(445, 56);
            this.btnAddPrescription.Name = "btnAddPrescription";
            this.btnAddPrescription.Size = new System.Drawing.Size(75, 49);
            this.btnAddPrescription.TabIndex = 13;
            this.btnAddPrescription.Text = "Add Prescription";
            this.btnAddPrescription.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pRESCRIPTIONIDDataGridViewTextBoxColumn,
            this.pATIENTIDDataGridViewTextBoxColumn,
            this.pRESCRIPTIONNAMEDataGridViewTextBoxColumn,
            this.cONSUMPTIONMETHODDataGridViewTextBoxColumn,
            this.rEFILLNUMBERDataGridViewTextBoxColumn,
            this.pRESCRIPTIONDATEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pRESCRIPTIONBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(32, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(394, 159);
            this.dataGridView1.TabIndex = 16;
            // 
            // xYZINCDataSetFinalv2
            // 
            this.xYZINCDataSetFinalv2.DataSetName = "XYZINCDataSetFinalv2";
            this.xYZINCDataSetFinalv2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRESCRIPTIONBindingSource
            // 
            this.pRESCRIPTIONBindingSource.DataMember = "PRESCRIPTION";
            this.pRESCRIPTIONBindingSource.DataSource = this.xYZINCDataSetFinalv2;
            // 
            // pRESCRIPTIONTableAdapter
            // 
            this.pRESCRIPTIONTableAdapter.ClearBeforeFill = true;
            // 
            // pRESCRIPTIONIDDataGridViewTextBoxColumn
            // 
            this.pRESCRIPTIONIDDataGridViewTextBoxColumn.DataPropertyName = "PRESCRIPTION_ID";
            this.pRESCRIPTIONIDDataGridViewTextBoxColumn.HeaderText = "PRESCRIPTION_ID";
            this.pRESCRIPTIONIDDataGridViewTextBoxColumn.Name = "pRESCRIPTIONIDDataGridViewTextBoxColumn";
            // 
            // pATIENTIDDataGridViewTextBoxColumn
            // 
            this.pATIENTIDDataGridViewTextBoxColumn.DataPropertyName = "PATIENT_ID";
            this.pATIENTIDDataGridViewTextBoxColumn.HeaderText = "PATIENT_ID";
            this.pATIENTIDDataGridViewTextBoxColumn.Name = "pATIENTIDDataGridViewTextBoxColumn";
            // 
            // pRESCRIPTIONNAMEDataGridViewTextBoxColumn
            // 
            this.pRESCRIPTIONNAMEDataGridViewTextBoxColumn.DataPropertyName = "PRESCRIPTION_NAME";
            this.pRESCRIPTIONNAMEDataGridViewTextBoxColumn.HeaderText = "PRESCRIPTION_NAME";
            this.pRESCRIPTIONNAMEDataGridViewTextBoxColumn.Name = "pRESCRIPTIONNAMEDataGridViewTextBoxColumn";
            // 
            // cONSUMPTIONMETHODDataGridViewTextBoxColumn
            // 
            this.cONSUMPTIONMETHODDataGridViewTextBoxColumn.DataPropertyName = "CONSUMPTION_METHOD";
            this.cONSUMPTIONMETHODDataGridViewTextBoxColumn.HeaderText = "CONSUMPTION_METHOD";
            this.cONSUMPTIONMETHODDataGridViewTextBoxColumn.Name = "cONSUMPTIONMETHODDataGridViewTextBoxColumn";
            // 
            // rEFILLNUMBERDataGridViewTextBoxColumn
            // 
            this.rEFILLNUMBERDataGridViewTextBoxColumn.DataPropertyName = "REFILL_NUMBER";
            this.rEFILLNUMBERDataGridViewTextBoxColumn.HeaderText = "REFILL_NUMBER";
            this.rEFILLNUMBERDataGridViewTextBoxColumn.Name = "rEFILLNUMBERDataGridViewTextBoxColumn";
            // 
            // pRESCRIPTIONDATEDataGridViewTextBoxColumn
            // 
            this.pRESCRIPTIONDATEDataGridViewTextBoxColumn.DataPropertyName = "PRESCRIPTION_DATE";
            this.pRESCRIPTIONDATEDataGridViewTextBoxColumn.HeaderText = "PRESCRIPTION_DATE";
            this.pRESCRIPTIONDATEDataGridViewTextBoxColumn.Name = "pRESCRIPTIONDATEDataGridViewTextBoxColumn";
            // 
            // frmPrescriptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlHome);
            this.Name = "frmPrescriptions";
            this.Text = "frmPrescriptions";
            this.Load += new System.EventHandler(this.frmPrescriptions_Load);
            this.pnlHome.ResumeLayout(false);
            this.pnlHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xYZINCDataSetFinalv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRESCRIPTIONBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.Label lblTitlePrescription;
        private System.Windows.Forms.Button btnHomePatient;
        private System.Windows.Forms.Button btnEditPrescription;
        private System.Windows.Forms.Button btnAddPrescription;
        private System.Windows.Forms.DataGridView dataGridView1;
        private XYZINCDataSetFinalv2 xYZINCDataSetFinalv2;
        private System.Windows.Forms.BindingSource pRESCRIPTIONBindingSource;
        private XYZINCDataSetFinalv2TableAdapters.PRESCRIPTIONTableAdapter pRESCRIPTIONTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRESCRIPTIONIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pATIENTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRESCRIPTIONNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONSUMPTIONMETHODDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEFILLNUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRESCRIPTIONDATEDataGridViewTextBoxColumn;
    }
}