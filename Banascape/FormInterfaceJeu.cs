using System;
using System.Drawing;
using System.Windows.Forms;

namespace Banascape
{
    public partial class frmInterfaceJeu : Form
    {
        private FormMenuEchap formMenuEchap;

        private int positionVerticaleJoueur = 1;
        private int positionHorizontaleJoueur = 1;

        private Image mur;
        private Image joueur;
        private Image clef;
        private Image porte;


        Partie partie = new Partie("pedro",20,20);

        private const int tailleImage = 60;

        public frmInterfaceJeu()
        {
            InitializeComponent();
            formMenuEchap = new FormMenuEchap();
            this.KeyDown += new KeyEventHandler(FormInterfaceJeu_KeyDown);
            this.KeyPreview = true;

            mur = Properties.Resources.mur;
            joueur = Properties.Resources.Banane;
            clef = Properties.Resources.trophee;
            porte = Properties.Resources.Porte;
            this.ClientSize = new Size(tailleImage * partie.Longueur, tailleImage * partie.Largeur);
        }

        private void FormInterfaceJeu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (!formMenuEchap.Visible)
                {
                    formMenuEchap.Show();
                }
            }
            else
            {
                if (e.KeyCode == Keys.Z || e.KeyCode == Keys.Q || e.KeyCode == Keys.S || e.KeyCode == Keys.D)
                {
                    DeplacerJoueur(e);                 
                }
            }
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;


            int offsetX = (this.ClientSize.Width - (partie.Longueur * tailleImage)) / 2;
            int offsetY = (this.ClientSize.Height - (partie.Largeur * tailleImage)) / 2;

            Rectangle zoneDessin = e.ClipRectangle;

            for (int r = 0; r < partie.Largeur; r++)
            {
                for (int c = 0; c < partie.Longueur; c++)
                {
                    Rectangle celluleRectangle = new Rectangle(offsetX + c * tailleImage, offsetY + r * tailleImage, tailleImage, tailleImage);

                    //On vérie si la cellule est dans la zone à redessiner
                    if (zoneDessin.IntersectsWith(celluleRectangle))
                    {
                        if(partie.Labyrinthe[r, c] == 1)
                            g.DrawImage(mur, celluleRectangle);
                        if (partie.Labyrinthe[r, c] == 2)
                            g.DrawImage(clef, celluleRectangle);
                        if (partie.Labyrinthe[r, c] == 3)
                            g.DrawImage(porte, celluleRectangle);
                    }
                }
            }

            // Dessiner le joueur dans la nouvelle cellule
            Rectangle joueurCellule = new Rectangle(offsetX + positionHorizontaleJoueur * tailleImage, offsetY + positionVerticaleJoueur * tailleImage, tailleImage, tailleImage);
            g.DrawImage(joueur, joueurCellule);
        }

            private void DeplacerJoueur(KeyEventArgs e)
        {    
            int nouvellePositionVerticale = positionVerticaleJoueur;
            int nouvellePositionHorizontale = positionHorizontaleJoueur;

            switch (e.KeyCode)
            {
                case Keys.Z:
                    nouvellePositionVerticale--;
                    break;
                case Keys.S:
                    nouvellePositionVerticale++;
                    break;
                case Keys.Q:
                    nouvellePositionHorizontale--;
                    break;
                case Keys.D:
                    nouvellePositionHorizontale++;
                    break;
            }

            if (nouvellePositionVerticale >= 0 && nouvellePositionVerticale < partie.Largeur && nouvellePositionHorizontale >= 0 && nouvellePositionHorizontale < partie.Longueur && partie.Labyrinthe[nouvellePositionVerticale, nouvellePositionHorizontale] == 0)
            {
                // Mémoriser l'ancienne position du joueur pour pouvoir la redessiner ensuite
                int anciennePositionVerticale = positionVerticaleJoueur;
                int anciennePositionHorizontale = positionHorizontaleJoueur;

                positionVerticaleJoueur = nouvellePositionVerticale;
                positionHorizontaleJoueur = nouvellePositionHorizontale;

                int offsetX = (this.ClientSize.Width - (partie.Longueur * tailleImage)) / 2;
                int offsetY = (this.ClientSize.Height - (partie.Largeur * tailleImage)) / 2;
                Rectangle ancienneCellule = new Rectangle(offsetX + anciennePositionHorizontale * tailleImage, offsetY + anciennePositionVerticale * tailleImage, tailleImage, tailleImage);
                Rectangle nouvelleCellule = new Rectangle(offsetX + nouvellePositionHorizontale * tailleImage, offsetY + nouvellePositionVerticale * tailleImage, tailleImage, tailleImage);

                // Redessiner l'ancienne et la nouvelle cellule
                labyrinthePanel.Invalidate(ancienneCellule);
                labyrinthePanel.Invalidate(nouvelleCellule);

            }
        }
    }
}
