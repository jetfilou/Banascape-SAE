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


        Partie partie = new Partie("pedro", 20, 20);

        private const int tailleImage = 60;

        public frmInterfaceJeu(string pseudo,bool diff)
        {
            InitializeComponent();
            formMenuEchap = new FormMenuEchap();
            this.KeyDown += new KeyEventHandler(FormInterfaceJeu_KeyDown);
            this.KeyPreview = true;

            mur = Properties.Resources.mur;
            joueur = redimentionerImage(Properties.Resources.Banane, 60, 44);
            clef = Properties.Resources.clef;
            porte = Properties.Resources.porte_refaite;
            this.ClientSize = new Size(tailleImage * partie.Longueur, tailleImage * partie.Largeur);
            picClef.Image = Properties.Resources.clef_vide;
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

            if (e.KeyCode == Keys.Enter && partie.Labyrinthe[positionVerticaleJoueur, positionHorizontaleJoueur] == 3 && partie.Porte == true)
            {
                ChargerNouveauLabyrinthe();
            }
            else
            {
                if (e.KeyCode == Keys.Z || e.KeyCode == Keys.Q || e.KeyCode == Keys.S || e.KeyCode == Keys.D || e.KeyCode == Keys.Right || e.KeyCode == Keys.Left || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
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
                        if (partie.Labyrinthe[r, c] == 1)
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
                case Keys.Up:
                    nouvellePositionVerticale--;
                    break;
                case Keys.S:
                case Keys.Down:
                    nouvellePositionVerticale++;
                    break;
                case Keys.Q:
                case Keys.Left:
                    nouvellePositionHorizontale--;
                    break;
                case Keys.D:
                case Keys.Right:
                    nouvellePositionHorizontale++;
                    break;
            }

            if (nouvellePositionVerticale >= 0 && nouvellePositionVerticale < partie.Largeur && nouvellePositionHorizontale >= 0 && nouvellePositionHorizontale < partie.Longueur && (partie.Labyrinthe[nouvellePositionVerticale, nouvellePositionHorizontale] == 0 || partie.Labyrinthe[nouvellePositionVerticale, nouvellePositionHorizontale] == 2) || partie.Labyrinthe[nouvellePositionVerticale, nouvellePositionHorizontale] == 3)
            {
                if (partie.Labyrinthe[nouvellePositionVerticale, nouvellePositionHorizontale] == 2)
                {
                    partie.ChangementClef();
                    partie.Labyrinthe[nouvellePositionVerticale, nouvellePositionHorizontale] = 0;
                    picClef.Image = Properties.Resources.clef;

                }
                if (partie.Labyrinthe[nouvellePositionVerticale, nouvellePositionHorizontale] == 2 || partie.Clef == true)
                {
                    partie.ChangementPorte();
                    porte = Properties.Resources.porte_ouverte;

                }
                // Déplacement autorisé
                // Mémoriser l'ancienne position du joueur
                int anciennePositionVerticale = positionVerticaleJoueur;
                int anciennePositionHorizontale = positionHorizontaleJoueur;

                // Mettre à jour la position actuelle du joueur
                positionVerticaleJoueur = nouvellePositionVerticale;
                positionHorizontaleJoueur = nouvellePositionHorizontale;

                // Calculer les coordonnées des rectangles à redessiner
                int offsetX = (this.ClientSize.Width - (partie.Longueur * tailleImage)) / 2;
                int offsetY = (this.ClientSize.Height - (partie.Largeur * tailleImage)) / 2;
                Rectangle ancienneCellule = new Rectangle(offsetX + anciennePositionHorizontale * tailleImage, offsetY + anciennePositionVerticale * tailleImage, tailleImage, tailleImage);
                Rectangle nouvelleCellule = new Rectangle(offsetX + nouvellePositionHorizontale * tailleImage, offsetY + nouvellePositionVerticale * tailleImage, tailleImage, tailleImage);

                // Redessiner l'ancienne et la nouvelle cellule
                labyrinthePanel.Invalidate(ancienneCellule);
                labyrinthePanel.Invalidate(nouvelleCellule);
            }

        }
        private void ChargerNouveauLabyrinthe()
        {
            partie.ChargerNouveauLabyrinthe();
            positionVerticaleJoueur = 1;
            positionHorizontaleJoueur = 1;
            labyrinthePanel.Invalidate();
            lblNiveau.Text = $"Niveau : {partie.Niveau}";
            porte = Properties.Resources.porte_refaite;
            picClef.Image = Properties.Resources.clef_vide;
            partie.AugmenterPoint();
            lblPoint.Text = $"Points : {partie.Point}";

        }

        private Image redimentionerImage(Image imageARedimentionner, int largeur, int longeur)
        {
            Bitmap b = new Bitmap(largeur, longeur);
            using (Graphics g = Graphics.FromImage(b))
            {
                g.DrawImage(imageARedimentionner, 0, 0, largeur, longeur);
            }
            return (Image)b;
        }
    }
}