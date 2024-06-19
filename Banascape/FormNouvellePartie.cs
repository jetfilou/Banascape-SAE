namespace Banascape
{
    public partial class frmNouvellePartie : Form
    {
        //Déclaration de la variable Difficulte
        bool difficulte;

        // Constructeur du formulaire frmNouvellePartie
        // Cache les labels d'alerte
        public frmNouvellePartie()
        {
            InitializeComponent();
            lblAlertPseudo.Hide();
            lblAlertDifficulter.Hide();
        }

        // Gestionnaire d'événements Click pour le bouton Retour
        // Instancie et affiche le formulaire frmMenuPrincipal, puis ferme le formulaire actuel
        // paramètre :
        //    sender : objet source de l'événement
        //    e : arguments de l'événement
        private void btnRetour_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frmMenuPrincipal;
            frmMenuPrincipal = new frmMenuPrincipal();
            frmMenuPrincipal.Show();
            this.Close();
        }

        // Gestionnaire d'événements Click pour le bouton Lancer
        // Vérifie si un pseudo et une difficulté sont sélectionnés avant de lancer le jeu
        // paramètre :
        //    sender : objet source de l'événement
        //    e : arguments de l'événement
        private void btnLancer_Click(object sender, EventArgs e)
        {
            if (txtPseudo.Text != "")
            {
                if (cmbDifficulte.Text != "")
                {
                    difficulte = cmbDifficulte.SelectedItem.ToString() == "Normal" ? true : false;

                    frmInterfaceJeu frmjeu;
                    frmjeu = new frmInterfaceJeu(txtPseudo.Text, difficulte);
                    frmjeu.ShowDialog();
                    this.Hide();
                }
                else
                {
                    lblAlertDifficulter.Show();
                }
            }
            else
            {
                lblAlertPseudo.Show();
            }

        }


    }
}
