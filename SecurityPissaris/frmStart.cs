using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecurityPissaris
{
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();
        }

        private void btnMD5_Click(object sender, EventArgs e)
        {
            frmMD5 frmMD5 = new frmMD5();
            frmMD5.Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {

        }

        private void btnRSA_Click(object sender, EventArgs e)
        {
            frmRSA frmRSA = new frmRSA();
            frmRSA.Show();
        }

        private void btnAES_Click(object sender, EventArgs e)
        {
            frmAES frmAES = new frmAES();
            frmAES.Show();
        }
    }
}
