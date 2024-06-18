using System;
using System.Drawing;
using System.Windows.Forms;

namespace Banascape
{
    public partial class frmInterfaceJeu : Form
    {
        private FormMenuEchap formMenuEchap;
        private System.Windows.Forms.Timer tempsAvantProchainDeplacement;
        private System.Windows.Forms.Timer durerStunt;
        private Partie partie;
        private Ennemie ennemieN1, ennemieN2, ennemieN3;
        private Random random = new Random();

        private int positionVerticaleJoueur = 1;
        private int positionHorizontaleJoueur = 1;
        private int IntervalTimer = 500;
        private const int tailleImage = 60;

        private Image mur;
        private Image joueur;
        private Image clef;
        private Image porte;
        private Image ennemie;
        private Image caise;

        public frmInterfaceJeu(string pseudo, bool diff)
        {
            InitializeComponent();

            int dimension = diff ? 15 : 40;
            partie = new Partie(pseudo, dimension, dimension);
            this.ClientSize = new Size(tailleImage * partie.Longueur, tailleImage * partie.Largeur);

            formMenuEchap = new FormMenuEchap();
            this.KeyDown += FormInterfaceJeu_KeyDown;
            this.KeyPreview = true;

            mur = Properties.Resources.mur;
            clef = Properties.Resources.clef;
            porte = Properties.Resources.porte_refaite;
            caise = Properties.Resources.caisse;
            ennemie = Properties.Resources.ennemi;
            joueur = Properties.Resources.Banane;
            picClef.Image = Properties.Resources.clef_vide;

            tempsAvantProchainDeplacement = new System.Windows.Forms.Timer
            {
                Interval = IntervalTimer
            };
            tempsAvantProchainDeplacement.Tick += LancementDeplacementEnnemie;
            tempsAvantProchainDeplacement.Start();

            durerStunt = new System.Windows.Forms.Timer
            {
                Interval = 5000
            };
            durerStunt.Tick += ImmobilisationEnnemie;

            RechercheEnemie();
        }

        private void ImmobilisationEnnemie(object sender, EventArgs e)
        {
            tempsAvantProchainDeplacement.Start();
            durerStunt.Stop();
            partie.ChangementInvincible();
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

            if (e.KeyCode == Keys.Enter && partie.Labyrinthe[positionVerticaleJoueur, positionHorizontaleJoueur] == 5)
            {
                partie.ChangementObjetRamaser(ObjetAleatoire());
                partie.Labyrinthe[positionVerticaleJoueur, positionHorizontaleJoueur] = 0;
                switch (partie.TypeObjet)
                {
                    case 1:
                        picObjet.Image = Properties.Resources.soin;
                        break;
                    case 2:
                        picObjet.Image = Properties.Resources.taser;
                        break;
                }
            }

            if (e.KeyCode == Keys.E && partie.Objet)
            {
                switch (partie.TypeObjet)
                {
                    case 1:
                        UtiliserSoin();
                        break;
                    case 2:
                        UtiliserTaser();
                        break;
                }
            }

            if (e.KeyCode == Keys.Enter && partie.Labyrinthe[positionVerticaleJoueur, positionHorizontaleJoueur] == 3 && partie.Porte)
            {
                ChargerNouveauLabyrinthe();
            }
            else if (e.KeyCode == Keys.Z || e.KeyCode == Keys.Q || e.KeyCode == Keys.S || e.KeyCode == Keys.D ||
                     e.KeyCode == Keys.Right || e.KeyCode == Keys.Left || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                DeplacerJoueur(e);
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

                    if (zoneDessin.IntersectsWith(celluleRectangle))
                    {
                        switch (partie.Labyrinthe[r, c])
                        {
                            case 1:
                                g.DrawImage(mur, celluleRectangle);
                                break;
                            case 2:
                                g.DrawImage(clef, celluleRectangle);
                                break;
                            case 3:
                                g.DrawImage(porte, celluleRectangle);
                                break;
                            case 4:
                                g.DrawImage(ennemie, celluleRectangle);
                                break;
                            case 5:
                                g.DrawImage(caise, celluleRectangle);
                                break;
                        }
                    }
                }
            }

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

            if (nouvellePositionVerticale >= 0 && nouvellePositionVerticale < partie.Largeur &&
                nouvellePositionHorizontale >= 0 && nouvellePositionHorizontale < partie.Longueur &&
                partie.Labyrinthe[nouvellePositionVerticale, nouvellePositionHorizontale] == 0)
            {
                int anciennePositionVerticale = positionVerticaleJoueur;
                int anciennePositionHorizontale = positionHorizontaleJoueur;

                positionVerticaleJoueur = nouvellePositionVerticale;
                positionHorizontaleJoueur = nouvellePositionHorizontale;

                int offsetX = (this.ClientSize.Width - (partie.Longueur * tailleImage)) / 2;
                int offsetY = (this.ClientSize.Height - (partie.Largeur * tailleImage)) / 2;
                Rectangle ancienneCellule = new Rectangle(offsetX + anciennePositionHorizontale * tailleImage, offsetY + anciennePositionVerticale * tailleImage, tailleImage, tailleImage);
                Rectangle nouvelleCellule = new Rectangle(offsetX + nouvellePositionHorizontale * tailleImage, offsetY + nouvellePositionVerticale * tailleImage, tailleImage, tailleImage);

                labyrinthePanel.Invalidate(ancienneCellule);
                labyrinthePanel.Invalidate(nouvelleCellule);
            }
        }

        private void RechercheEnemie()
        {
            for (int i = 0; i < partie.Largeur; i++)
            {
                for (int j = 0; j < partie.Longueur; j++)
                {
                    if (partie.Labyrinthe[i, j] == 4)
                    {
                        if (ennemieN1 == null)
                        {
                            ennemieN1 = new Ennemie(i, j);
                        }
                        else if (ennemieN2 == null)
                        {
                            ennemieN2 = new Ennemie(i, j);
                        }
                        else if (ennemieN3 == null)
                        {
                            ennemieN3 = new Ennemie(i, j);
                        }
                    }
                }
            }
        }

        private void LancementDeplacementEnnemie(object sender, EventArgs e)
        {
            if (ennemieN1 != null)
            {
                DeplacerEnnemie(ennemieN1);
            }
            if (ennemieN2 != null)
            {
                DeplacerEnnemie(ennemieN2);
            }
            if (ennemieN3 != null)
            {
                DeplacerEnnemie(ennemieN3);
            }
        }

        private void DeplacerEnnemie(Ennemie ennemie)
        {
            int nouvellePositionVerticale = ennemie.PositionVerticale;
            int nouvellePositionHorizontale = ennemie.PositionHorizontale;

            int direction = random.Next(4);

            switch (direction)
            {
                case 0:
                    nouvellePositionVerticale--;
                    break;
                case 1:
                    nouvellePositionVerticale++;
                    break;
                case 2:
                    nouvellePositionHorizontale--;
                    break;
                case 3:
                    nouvellePositionHorizontale++;
                    break;
            }

            if (nouvellePositionVerticale >= 0 && nouvellePositionVerticale < partie.Largeur &&
                nouvellePositionHorizontale >= 0 && nouvellePositionHorizontale < partie.Longueur &&
                partie.Labyrinthe[nouvellePositionVerticale, nouvellePositionHorizontale] == 0)
            {
                partie.Labyrinthe[ennemie.PositionVerticale, ennemie.PositionHorizontale] = 0;
                partie.Labyrinthe[nouvellePositionVerticale, nouvellePositionHorizontale] = 4;

                ennemie.PositionVerticale = nouvellePositionVerticale;
                ennemie.PositionHorizontale = nouvellePositionHorizontale;

                int offsetX = (this.ClientSize.Width - (partie.Longueur * tailleImage)) / 2;
                int offsetY = (this.ClientSize.Height - (partie.Largeur * tailleImage)) / 2;
                Rectangle ancienneCellule = new Rectangle(offsetX + ennemie.PositionHorizontale * tailleImage, offsetY + ennemie.PositionVerticale * tailleImage, tailleImage, tailleImage);
                Rectangle nouvelleCellule = new Rectangle(offsetX + nouvellePositionHorizontale * tailleImage, offsetY + nouvellePositionVerticale * tailleImage, tailleImage, tailleImage);

                labyrinthePanel.Invalidate(ancienneCellule);
                labyrinthePanel.Invalidate(nouvelleCellule);
            }
        }

        private void UtiliserSoin()
        {
            partie.ChangementVie(50);
            partie.ChangementObjet();
            picObjet.Image = null;
        }

        private void UtiliserTaser()
        {
            partie.ChangementObjet();
            partie.ChangementInvincible();
            tempsAvantProchainDeplacement.Stop();
            durerStunt.Start();
            picObjet.Image = null;
        }

        private void ChargerNouveauLabyrinthe()
        {
            partie.ChargementLabyrinthe();
            positionHorizontaleJoueur = 1;
            positionVerticaleJoueur = 1;
            ennemieN1 = null;
            ennemieN2 = null;
            ennemieN3 = null;
            RechercheEnemie();
            picClef.Image = Properties.Resources.clef_vide;
            partie.ChangementPorte();
            partie.ChangementClef();
            labyrinthePanel.Invalidate();
        }

        private int ObjetAleatoire()
        {
            return random.Next(1, 3);
        }
    }
}