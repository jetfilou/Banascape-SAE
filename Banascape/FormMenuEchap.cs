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
    public partial class FormMenuEchap : Form
    {
        public FormMenuEchap()
        {
            InitializeComponent();

            this.KeyDown += new KeyEventHandler(FormMenuEchap_KeyDown);
            this.KeyPreview = true;
        }

        private void FormMenuEchap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Hide();
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            DialogResult resultat = MessageBox.Show("Voulez-vous vraiment quitter le jeu ?", "Confirmation",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultat == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnRetourMenuPrincipal_Click(object sender, EventArgs e)
        {
            DialogResult resultat = MessageBox.Show("Voulez-vous vraiment retourner au menu Principal ?", "Confirmation",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultat == DialogResult.Yes)
            {
                this.Close();
                Application.OpenForms["frmMenuPrincipal"]?.Show();
                Application.OpenForms["frmInterfaceJeu"]?.Close();
                
            }
        }
    }
}
