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
    public partial class frmPrescriptions : Form
    {
        public frmPrescriptions()
        {
            InitializeComponent();
        }

        private void frmPrescriptions_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'xYZINCDataSetFinalv2.PRESCRIPTION' table. You can move, or remove it, as needed.
            this.pRESCRIPTIONTableAdapter.Fill(this.xYZINCDataSetFinalv2.PRESCRIPTION);

        }
    }
}
