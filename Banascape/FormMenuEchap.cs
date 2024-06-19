namespace Banascape
{
    public partial class FormMenuEchap : Form
    {
        // Constructeur du formulaire FormMenuEchap
        // Initialise le composant et configure les gestionnaires d'événements pour les touches
        public FormMenuEchap()
        {
            InitializeComponent();

            this.KeyDown += new KeyEventHandler(FormMenuEchap_KeyDown);
            this.KeyPreview = true;
        }

        // Gestionnaire d'événements touche presser pour la touche Echap
        // Cache le formulaire si la touche Échap est pressée
        // paramètre :
        //    sender : objet source de l'événement
        //    e : arguments de l'événement
        private void FormMenuEchap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Hide();
            }
        }

        // Gestionnaire d'événements Click pour le bouton Play
        // Cache le formulaire quand le bouton Play est cliqué
        // paramètre :
        //    sender : objet source de l'événement
        //    e : arguments de l'événement
        private void btnPlay_Click(object sender, EventArgs e)
        {
            this.Hide();
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

        // Gestionnaire d'événements Click pour le bouton Retour au Menu Principal
        // Affiche une boîte de dialogue de confirmation et retourne au menu principal si l'utilisateur confirme
        // paramètre :
        //    sender : objet source de l'événement
        //    e : arguments de l'événement
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
