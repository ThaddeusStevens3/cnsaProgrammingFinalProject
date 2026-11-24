namespace DoctorXYZ
{
    partial class frmPatients
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
            System.Windows.Forms.Label lblTitlePatient;
            this.pnlHome = new System.Windows.Forms.Panel();
            this.pATIENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.xYZINCDataSet = new DoctorXYZ.XYZINCDataSet();
            this.btnHomePatient = new System.Windows.Forms.Button();
            this.btnEditPatient = new System.Windows.Forms.Button();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.pATIENTTableAdapter = new DoctorXYZ.XYZINCDataSetTableAdapters.PATIENTTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.xYZINCDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pATIENTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pATIENTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pATIENTFIRSTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pATIENTLASTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pATIENTMIDDLENAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pATIENTCELLPHONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pATIENTHOMEPHONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pATIENTEMAIL1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pATIENTEMAIL2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pATIENTGENDERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pATIENTACCOUNTBALANCEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNSURANCEPROVIDERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pATIENTCITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pATIENTSTATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pATIENTSTREETDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pATIENTZIPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lblTitlePatient = new System.Windows.Forms.Label();
            this.pnlHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xYZINCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xYZINCDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitlePatient
            // 
            lblTitlePatient.AutoSize = true;
            lblTitlePatient.BackColor = System.Drawing.Color.Transparent;
            lblTitlePatient.ForeColor = System.Drawing.SystemColors.ControlText;
            lblTitlePatient.Location = new System.Drawing.Point(381, 20);
            lblTitlePatient.Name = "lblTitlePatient";
            lblTitlePatient.Size = new System.Drawing.Size(45, 13);
            lblTitlePatient.TabIndex = 1;
            lblTitlePatient.Text = "Patients";
            // 
            // pnlHome
            // 
            this.pnlHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(240)))), ((int)(((byte)(194)))));
            this.pnlHome.Controls.Add(this.dataGridView1);
            this.pnlHome.Controls.Add(this.btnHomePatient);
            this.pnlHome.Controls.Add(this.btnEditPatient);
            this.pnlHome.Controls.Add(this.btnAddPatient);
            this.pnlHome.Controls.Add(lblTitlePatient);
            this.pnlHome.Location = new System.Drawing.Point(12, 12);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(776, 426);
            this.pnlHome.TabIndex = 2;
            // 
            // pATIENTBindingSource
            // 
            this.pATIENTBindingSource.DataMember = "PATIENT";
            this.pATIENTBindingSource.DataSource = this.xYZINCDataSet;
            // 
            // xYZINCDataSet
            // 
            this.xYZINCDataSet.DataSetName = "XYZINCDataSet";
            this.xYZINCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnHomePatient
            // 
            this.btnHomePatient.Location = new System.Drawing.Point(681, 257);
            this.btnHomePatient.Name = "btnHomePatient";
            this.btnHomePatient.Size = new System.Drawing.Size(75, 23);
            this.btnHomePatient.TabIndex = 12;
            this.btnHomePatient.Text = "Home";
            this.btnHomePatient.UseVisualStyleBackColor = true;
            // 
            // btnEditPatient
            // 
            this.btnEditPatient.Location = new System.Drawing.Point(681, 116);
            this.btnEditPatient.Name = "btnEditPatient";
            this.btnEditPatient.Size = new System.Drawing.Size(75, 49);
            this.btnEditPatient.TabIndex = 11;
            this.btnEditPatient.Text = "Edit Patient";
            this.btnEditPatient.UseVisualStyleBackColor = true;
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Location = new System.Drawing.Point(681, 61);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(75, 49);
            this.btnAddPatient.TabIndex = 10;
            this.btnAddPatient.Text = "Add Patient";
            this.btnAddPatient.UseVisualStyleBackColor = true;
            // 
            // pATIENTTableAdapter
            // 
            this.pATIENTTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pATIENTIDDataGridViewTextBoxColumn,
            this.pATIENTFIRSTNAMEDataGridViewTextBoxColumn,
            this.pATIENTLASTNAMEDataGridViewTextBoxColumn,
            this.pATIENTMIDDLENAMEDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.pATIENTCELLPHONEDataGridViewTextBoxColumn,
            this.pATIENTHOMEPHONEDataGridViewTextBoxColumn,
            this.pATIENTEMAIL1DataGridViewTextBoxColumn,
            this.pATIENTEMAIL2DataGridViewTextBoxColumn,
            this.pATIENTGENDERDataGridViewTextBoxColumn,
            this.pATIENTACCOUNTBALANCEDataGridViewTextBoxColumn,
            this.iNSURANCEPROVIDERDataGridViewTextBoxColumn,
            this.pATIENTCITYDataGridViewTextBoxColumn,
            this.pATIENTSTATEDataGridViewTextBoxColumn,
            this.pATIENTSTREETDataGridViewTextBoxColumn,
            this.pATIENTZIPDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pATIENTBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(81, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(562, 219);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // xYZINCDataSetBindingSource
            // 
            this.xYZINCDataSetBindingSource.DataSource = this.xYZINCDataSet;
            this.xYZINCDataSetBindingSource.Position = 0;
            // 
            // pATIENTBindingSource1
            // 
            this.pATIENTBindingSource1.DataMember = "PATIENT";
            this.pATIENTBindingSource1.DataSource = this.xYZINCDataSetBindingSource;
            // 
            // pATIENTIDDataGridViewTextBoxColumn
            // 
            this.pATIENTIDDataGridViewTextBoxColumn.DataPropertyName = "PATIENT_ID";
            this.pATIENTIDDataGridViewTextBoxColumn.HeaderText = "PATIENT_ID";
            this.pATIENTIDDataGridViewTextBoxColumn.Name = "pATIENTIDDataGridViewTextBoxColumn";
            // 
            // pATIENTFIRSTNAMEDataGridViewTextBoxColumn
            // 
            this.pATIENTFIRSTNAMEDataGridViewTextBoxColumn.DataPropertyName = "PATIENT_FIRST_NAME";
            this.pATIENTFIRSTNAMEDataGridViewTextBoxColumn.HeaderText = "PATIENT_FIRST_NAME";
            this.pATIENTFIRSTNAMEDataGridViewTextBoxColumn.Name = "pATIENTFIRSTNAMEDataGridViewTextBoxColumn";
            // 
            // pATIENTLASTNAMEDataGridViewTextBoxColumn
            // 
            this.pATIENTLASTNAMEDataGridViewTextBoxColumn.DataPropertyName = "PATIENT_LAST_NAME";
            this.pATIENTLASTNAMEDataGridViewTextBoxColumn.HeaderText = "PATIENT_LAST_NAME";
            this.pATIENTLASTNAMEDataGridViewTextBoxColumn.Name = "pATIENTLASTNAMEDataGridViewTextBoxColumn";
            // 
            // pATIENTMIDDLENAMEDataGridViewTextBoxColumn
            // 
            this.pATIENTMIDDLENAMEDataGridViewTextBoxColumn.DataPropertyName = "PATIENT_MIDDLE_NAME";
            this.pATIENTMIDDLENAMEDataGridViewTextBoxColumn.HeaderText = "PATIENT_MIDDLE_NAME";
            this.pATIENTMIDDLENAMEDataGridViewTextBoxColumn.Name = "pATIENTMIDDLENAMEDataGridViewTextBoxColumn";
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            // 
            // pATIENTCELLPHONEDataGridViewTextBoxColumn
            // 
            this.pATIENTCELLPHONEDataGridViewTextBoxColumn.DataPropertyName = "PATIENT_CELL_PHONE";
            this.pATIENTCELLPHONEDataGridViewTextBoxColumn.HeaderText = "PATIENT_CELL_PHONE";
            this.pATIENTCELLPHONEDataGridViewTextBoxColumn.Name = "pATIENTCELLPHONEDataGridViewTextBoxColumn";
            // 
            // pATIENTHOMEPHONEDataGridViewTextBoxColumn
            // 
            this.pATIENTHOMEPHONEDataGridViewTextBoxColumn.DataPropertyName = "PATIENT_HOME_PHONE";
            this.pATIENTHOMEPHONEDataGridViewTextBoxColumn.HeaderText = "PATIENT_HOME_PHONE";
            this.pATIENTHOMEPHONEDataGridViewTextBoxColumn.Name = "pATIENTHOMEPHONEDataGridViewTextBoxColumn";
            // 
            // pATIENTEMAIL1DataGridViewTextBoxColumn
            // 
            this.pATIENTEMAIL1DataGridViewTextBoxColumn.DataPropertyName = "PATIENT_EMAIL1";
            this.pATIENTEMAIL1DataGridViewTextBoxColumn.HeaderText = "PATIENT_EMAIL1";
            this.pATIENTEMAIL1DataGridViewTextBoxColumn.Name = "pATIENTEMAIL1DataGridViewTextBoxColumn";
            // 
            // pATIENTEMAIL2DataGridViewTextBoxColumn
            // 
            this.pATIENTEMAIL2DataGridViewTextBoxColumn.DataPropertyName = "PATIENT_EMAIL2";
            this.pATIENTEMAIL2DataGridViewTextBoxColumn.HeaderText = "PATIENT_EMAIL2";
            this.pATIENTEMAIL2DataGridViewTextBoxColumn.Name = "pATIENTEMAIL2DataGridViewTextBoxColumn";
            // 
            // pATIENTGENDERDataGridViewTextBoxColumn
            // 
            this.pATIENTGENDERDataGridViewTextBoxColumn.DataPropertyName = "PATIENT_GENDER";
            this.pATIENTGENDERDataGridViewTextBoxColumn.HeaderText = "PATIENT_GENDER";
            this.pATIENTGENDERDataGridViewTextBoxColumn.Name = "pATIENTGENDERDataGridViewTextBoxColumn";
            // 
            // pATIENTACCOUNTBALANCEDataGridViewTextBoxColumn
            // 
            this.pATIENTACCOUNTBALANCEDataGridViewTextBoxColumn.DataPropertyName = "PATIENT_ACCOUNT_BALANCE";
            this.pATIENTACCOUNTBALANCEDataGridViewTextBoxColumn.HeaderText = "PATIENT_ACCOUNT_BALANCE";
            this.pATIENTACCOUNTBALANCEDataGridViewTextBoxColumn.Name = "pATIENTACCOUNTBALANCEDataGridViewTextBoxColumn";
            // 
            // iNSURANCEPROVIDERDataGridViewTextBoxColumn
            // 
            this.iNSURANCEPROVIDERDataGridViewTextBoxColumn.DataPropertyName = "INSURANCE_PROVIDER";
            this.iNSURANCEPROVIDERDataGridViewTextBoxColumn.HeaderText = "INSURANCE_PROVIDER";
            this.iNSURANCEPROVIDERDataGridViewTextBoxColumn.Name = "iNSURANCEPROVIDERDataGridViewTextBoxColumn";
            // 
            // pATIENTCITYDataGridViewTextBoxColumn
            // 
            this.pATIENTCITYDataGridViewTextBoxColumn.DataPropertyName = "PATIENT_CITY";
            this.pATIENTCITYDataGridViewTextBoxColumn.HeaderText = "PATIENT_CITY";
            this.pATIENTCITYDataGridViewTextBoxColumn.Name = "pATIENTCITYDataGridViewTextBoxColumn";
            // 
            // pATIENTSTATEDataGridViewTextBoxColumn
            // 
            this.pATIENTSTATEDataGridViewTextBoxColumn.DataPropertyName = "PATIENT_STATE";
            this.pATIENTSTATEDataGridViewTextBoxColumn.HeaderText = "PATIENT_STATE";
            this.pATIENTSTATEDataGridViewTextBoxColumn.Name = "pATIENTSTATEDataGridViewTextBoxColumn";
            // 
            // pATIENTSTREETDataGridViewTextBoxColumn
            // 
            this.pATIENTSTREETDataGridViewTextBoxColumn.DataPropertyName = "PATIENT_STREET";
            this.pATIENTSTREETDataGridViewTextBoxColumn.HeaderText = "PATIENT_STREET";
            this.pATIENTSTREETDataGridViewTextBoxColumn.Name = "pATIENTSTREETDataGridViewTextBoxColumn";
            // 
            // pATIENTZIPDataGridViewTextBoxColumn
            // 
            this.pATIENTZIPDataGridViewTextBoxColumn.DataPropertyName = "PATIENT_ZIP";
            this.pATIENTZIPDataGridViewTextBoxColumn.HeaderText = "PATIENT_ZIP";
            this.pATIENTZIPDataGridViewTextBoxColumn.Name = "pATIENTZIPDataGridViewTextBoxColumn";
            // 
            // frmPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlHome);
            this.Name = "frmPatients";
            this.Text = "frmPatients";
            this.Load += new System.EventHandler(this.frmPatients_Load);
            this.pnlHome.ResumeLayout(false);
            this.pnlHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xYZINCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xYZINCDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.Button btnEditPatient;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.Button btnHomePatient;
        private XYZINCDataSet xYZINCDataSet;
        private System.Windows.Forms.BindingSource pATIENTBindingSource;
        private XYZINCDataSetTableAdapters.PATIENTTableAdapter pATIENTTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pATIENTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pATIENTFIRSTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pATIENTLASTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pATIENTMIDDLENAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pATIENTCELLPHONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pATIENTHOMEPHONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pATIENTEMAIL1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pATIENTEMAIL2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pATIENTGENDERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pATIENTACCOUNTBALANCEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNSURANCEPROVIDERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pATIENTCITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pATIENTSTATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pATIENTSTREETDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pATIENTZIPDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pATIENTBindingSource1;
        private System.Windows.Forms.BindingSource xYZINCDataSetBindingSource;
    }
}