using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoctorXYZ
{
    public partial class frmPatients : Form
    {
        public frmPatients()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmPatients_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'xYZINCDataSet.PATIENT' table. You can move, or remove it, as needed.
            this.pATIENTTableAdapter.Fill(this.xYZINCDataSet.PATIENT);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
