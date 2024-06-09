using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banascape
{
    public partial class frmNouvellePartie : Form
    {
        public frmNouvellePartie()
        {
            InitializeComponent();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frmMenuPrincipal;
            frmMenuPrincipal = new frmMenuPrincipal();
            frmMenuPrincipal.Show();
            this.Close();
        }
    }
}
