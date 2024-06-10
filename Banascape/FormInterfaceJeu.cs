using System;
using System.Drawing;
using System.Windows.Forms;

namespace Banascape
{
    public partial class frmInterfaceJeu : Form
    {
        private FormMenuEchap formMenuEchap;
        private const int tailleCase = 30;
        private const int largeurLabyrinthe = 10;
        private const int longueurLabyrinthe = 10;
        private int positionVerticaleJoueur = 1;
        private int positionHorizontaleJoueur = 1;

        // Déclarez les images en tant que champs de classe
        private Image mur;
        private Image sol;
        private Image joueur;

        private int[,] labyrinthe = new int[largeurLabyrinthe, longueurLabyrinthe]
        {
            {1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
            {1, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            {1, 0, 1, 1, 1, 1, 1, 1, 0, 1},
            {1, 0, 1, 0, 0, 0, 0, 1, 0, 1},
            {1, 0, 1, 0, 1, 1, 0, 1, 0, 1},
            {1, 0, 1, 0, 0, 0, 0, 1, 0, 1},
            {1, 0, 1, 1, 0, 1, 1, 1, 0, 1},
            {1, 0, 1, 0, 0, 1, 1, 1, 0, 1},
            {1, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            {1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
        };

        private const int tailleImage = 60;

        public frmInterfaceJeu()
        {
            InitializeComponent();
            formMenuEchap = new FormMenuEchap();
            this.KeyDown += new KeyEventHandler(FormInterfaceJeu_KeyDown);
            this.KeyPreview = true;

            mur = Properties.Resources.mur;
            sol = Properties.Resources.sol;
            joueur = Properties.Resources.Banane;
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

            // Calculer les décalages pour centrer le labyrinthe
            int offsetX = (this.ClientSize.Width - (longueurLabyrinthe * tailleImage)) / 2;
            int offsetY = (this.ClientSize.Height - (largeurLabyrinthe * tailleImage)) / 2;

            for (int r = 0; r < largeurLabyrinthe; r++)
            {
                for (int c = 0; c < longueurLabyrinthe; c++)
                {
                    Image texture = labyrinthe[r, c] == 1 ? mur : sol;
                    // Dessiner l'image avec la nouvelle taille
                    g.DrawImage(texture, offsetX + c * tailleImage, offsetY + r * tailleImage, tailleImage, tailleImage);
                }
            }

            // Dessiner le joueur avec la nouvelle taille
            g.DrawImage(joueur, offsetX + positionHorizontaleJoueur * tailleImage, offsetY + positionVerticaleJoueur * tailleImage, tailleImage, tailleImage);
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

            if (nouvellePositionVerticale >= 0 && nouvellePositionVerticale < largeurLabyrinthe && nouvellePositionHorizontale >= 0 && nouvellePositionHorizontale < longueurLabyrinthe && labyrinthe[nouvellePositionVerticale, nouvellePositionHorizontale] == 0)
            {
                positionVerticaleJoueur = nouvellePositionVerticale;
                positionHorizontaleJoueur = nouvellePositionHorizontale;
                labyrinthePanel.Invalidate(); // Redessiner le panel
            }
        }
    }
}
