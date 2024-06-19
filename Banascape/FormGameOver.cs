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
        // Constructeur du formulaire frmGameOver
        // paramètre :
        //    point : entier (le score du joueur)
        //    Niveaux : entier (le niveau atteint par le joueur)
        //    pseudo : chaîne de caractères (le pseudo du joueur)
        public frmGameOver(int point,int Niveaux, string pseudo)
        {
            InitializeComponent();

            lblResultatNiveau.Text = Convert.ToString(Niveaux);
            lblResultatScore.Text = Convert.ToString(point);
            lblPseudoJoueur.Text = pseudo;
        }

        // Gestionnaire d'événements Click pour le bouton Quitter
        // Affiche une boîte de dialogue de confirmation et quitte l'application si l'utilisateur confirme
        // paramètre :
        //    sender : objet source de l'événement
        //    e : arguments de l'événement
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            DialogResult resultat = MessageBox.Show("Voulez-vous vraiment quitter le jeu ?", "Confirmation",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultat == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Gestionnaire d'événements Click pour le bouton Replay
        // Ferme le formulaire actuel et ouvre un nouveau formulaire Jeu
        // paramètre :
        //    sender : objet source de l'événement
        //    e : arguments de l'événement

        private void btnReplay_Click(object sender, EventArgs e)
        {
            this.Close();
            frmNouvellePartie frmNewPartie;

            frmNewPartie = new frmNouvellePartie();

            frmNewPartie.Show();
        }
    }
}
