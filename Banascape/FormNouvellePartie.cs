namespace Banascape
{
    public partial class frmNouvellePartie : Form
    {
        bool difficulte;
        public frmNouvellePartie()
        {
            InitializeComponent();
            lblAlertPseudo.Hide();
            lblAlertDifficulter.Hide();
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
