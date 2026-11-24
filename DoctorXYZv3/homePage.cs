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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnToPatients_Click(object sender, EventArgs e)
        {
            
        }

        private void mnuContextExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
