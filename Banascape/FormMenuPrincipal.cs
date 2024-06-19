namespace Banascape
{
    public partial class frmMenuPrincipal : Form
    {
        // Constructeur du formulaire frmMenuPrincipal
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        // Gestionnaire d'événements Click pour le bouton Quitter
        // Affiche une boîte de dialogue de confirmation et quitte l'application si l'utilisateur confirme
        // paramètre :
        //    sender : objet source de l'événement
        //    e : arguments de l'événement
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

        // Gestionnaire d'événements Click pour le bouton Nouvelle Partie
        // Instancie et affiche le formulaire frmNouvellePartie, puis cache le formulaire actuel
        // paramètre :
        //    sender : objet source de l'événement
        //    e : arguments de l'événement
        private void btnNouvellePartie_Click(object sender, EventArgs e)
        {
            frmNouvellePartie frmNewPartie;
            // instanciation d'un objet de type FormNouvellePartie 
            frmNewPartie = new frmNouvellePartie();

            // ouverture du formulaire Nouvelle partie et fermeture de l'écran d'accueil
            frmNewPartie.Show();
            this.Hide();

        }

        // Gestionnaire d'événements Click pour le bouton Classement
        // Affiche le formulaire frmClassement, ou le met au premier plan s'il est déjà ouvert
        // paramètre :
        //    sender : objet source de l'événement
        //    e : arguments de l'événement
        private void btnClassement_Click(object sender, EventArgs e)
        {
            Form frmClassement = Application.OpenForms["frmClassement"];
            if (frmClassement != null)
            {
                frmClassement.TopMost = true;
            }
            else
            {
                frmClassement = new frmClassement();
                frmClassement.Show();
            }
        }

        // Gestionnaire d'événements Click pour le bouton Reprendre
        // Instancie et affiche le formulaire frmInterfaceJeu, puis cache le formulaire actuel
        // paramètre :
        //    sender : objet source de l'événement
        //    e : arguments de l'événement
        private void btnReprendre_Click(object sender, EventArgs e)
        {
            frmInterfaceJeu frmjeu;
            // instanciation d'un objet de type FormInterfaceJeu 
            frmjeu = new frmInterfaceJeu("Pedro", true);

            // ouverture du Jeu
            frmjeu.Show();
            this.Hide();
        }
    }
}
