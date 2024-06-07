namespace Banascape
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            DialogResult resultat = MessageBox.Show("Voulez-vous vraiment quitter le jeu ?",
                                      "Confirmation",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Question);
            if (resultat == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnNouvellePartie_Click(object sender, EventArgs e)
        { 
            FormNouvellePartie frmNewPartie;
            // instanciation d'un objet de type FormJeu 
            frmNewPartie = new FormNouvellePartie();

                // ouverture du formulaire Nouvelle partie et fermeture de l'écran d'accueil
                frmNewPartie.Show();
                this.Hide();
            
        }
    }
}
