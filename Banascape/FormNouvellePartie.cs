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
        private void btnLancer_Click(object sender, EventArgs e)
        {
            frmInterfaceJeu frmjeu;
            // instanciation d'un objet de type FormInterfaceJeu 
            frmjeu = new frmInterfaceJeu(txtPseudo.Text, true);

            // ouverture du Jeu
            frmjeu.ShowDialog();
            this.Hide();

        }


    }
}
