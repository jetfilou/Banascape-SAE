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
    public partial class frmGameOver : Form
    {
        public frmGameOver()
        {
            InitializeComponent();
            lblResultatNiveau.Text = "niveau";
            lblResultatScore.Text = "score";
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

        private void btnReplay_Click(object sender, EventArgs e)
        {
            this.Close();
            frmNouvellePartie frmNewPartie;
            // instanciation d'un objet de type FormNouvellePartie 
            frmNewPartie = new frmNouvellePartie();

            // ouverture du formulaire Nouvelle partie et fermeture de l'écran d'accueil
            frmNewPartie.Show();
        }
    }
}
