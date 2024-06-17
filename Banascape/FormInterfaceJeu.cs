using System;
using System.Drawing;
using System.Windows.Forms;

namespace Banascape
{
    public partial class frmInterfaceJeu : Form
    {
        private FormMenuEchap formMenuEchap;
        private System.Windows.Forms.Timer tempsAvantProchainDeplacement;


        private int positionVerticaleJoueur = 1;
        private int positionHorizontaleJoueur = 1;

        private Image mur;
        private Image joueur;
        private Image clef;
        private Image porte;
        private Image ennemie;
        private Image caise;

        private Partie partie;
        private Ennemie ennemieN1;

        private const int tailleImage = 60;

        private bool touchePresser = false;

        private Random random = new Random();

        public frmInterfaceJeu(string pseudo, bool diff)
        {
            InitializeComponent();
            int dimension = diff == true ? 15 : 40;
            partie = new Partie(pseudo, dimension, dimension);
            formMenuEchap = new FormMenuEchap();
            this.KeyDown += new KeyEventHandler(FormInterfaceJeu_KeyDown);
            this.KeyPreview = true;

            mur = Properties.Resources.mur;
            joueur = redimentionerImage(Properties.Resources.Banane, 60, 44);
            clef = Properties.Resources.clef;
            porte = Properties.Resources.porte_refaite;
            caise = Properties.Resources.caisse;

            this.ClientSize = new Size(tailleImage * partie.Longueur, tailleImage * partie.Largeur);
            picClef.Image = Properties.Resources.clef_vide;
            ennemie = Properties.Resources.ennemi;

            tempsAvantProchainDeplacement = new System.Windows.Forms.Timer();
            tempsAvantProchainDeplacement.Interval = 2000;
            tempsAvantProchainDeplacement.Tick += Timer_Tick;
            tempsAvantProchainDeplacement.Start();
            RechercheEnemie();
        }

        void RechercheEnemie()
        {
            for (int r = 0; r < partie.Largeur; r++)
            {
                for (int c = 0; c < partie.Longueur; c++)
                {
                    if (partie.Labyrinthe[r, c] == 4)
                    {
                        ennemieN1 = new Ennemie(r, c);
                    }
                }
            }
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
                        lblNiveau.Text = $"{partie.TypeObjet}";
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

                        if (partie.Vie < 2)
                        {
                            partie.AjoutrerVie();
                            picCoeur1.Image = Properties.Resources.coeur_plein;
                            partie.ChangementObjetUtilisé();
                            picObjet.Image = null;
                            break;
                        }
                        if (partie.Vie < 3)
                        {
                            partie.AjoutrerVie();
                            picCoeur2.Image = Properties.Resources.coeur_plein;
                            partie.ChangementObjetUtilisé();
                            picObjet.Image = null;
                            break;
                        }
                       
                        break;
                    case 2:
                        picObjet.Image = Properties.Resources.taser;
                        break;
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

                    // On vérifie si la cellule est dans la zone à redessiner
                    if (zoneDessin.IntersectsWith(celluleRectangle))
                    {
                        if (partie.Labyrinthe[r, c] == 1)
                            g.DrawImage(mur, celluleRectangle);
                        if (partie.Labyrinthe[r, c] == 2)
                            g.DrawImage(clef, celluleRectangle);
                        if (partie.Labyrinthe[r, c] == 3)
                            g.DrawImage(porte, celluleRectangle);
                        if (partie.Labyrinthe[r, c] == 4)
                            g.DrawImage(ennemie, celluleRectangle);
                        if (partie.Labyrinthe[r, c] == 5)
                            g.DrawImage(caise, celluleRectangle);
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
                    if (!touchePresser)
                    {
                        nouvellePositionVerticale--;
                        touchePresser = true;
                    }
                    break;
                case Keys.S:
                    if (!touchePresser)
                    {
                        nouvellePositionVerticale++;
                        touchePresser = true;
                    }
                    break;
                case Keys.Q:
                    if (!touchePresser)
                    {
                        nouvellePositionHorizontale--;
                        touchePresser = true;
                    }
                    break;
                case Keys.D:
                    if (!touchePresser)
                    {
                        nouvellePositionHorizontale++;
                        touchePresser = true;
                    }
                    break;
                case Keys.Right:
                    if (!touchePresser)
                    {
                        nouvellePositionHorizontale++;
                        touchePresser = true;
                    }
                    break;
                case Keys.Left:
                    if (!touchePresser)
                    {
                        nouvellePositionHorizontale--;
                        touchePresser = true;
                    }
                    break;
                case Keys.Up:
                    if (!touchePresser)
                    {
                        nouvellePositionVerticale--;
                        touchePresser = true;
                    }
                    break;
                case Keys.Down:
                    if (!touchePresser)
                    {
                        nouvellePositionVerticale++;
                        touchePresser = true;
                    }
                    break;
            }

            if (nouvellePositionVerticale >= 0 && nouvellePositionVerticale < partie.Largeur && nouvellePositionHorizontale >= 0 && nouvellePositionHorizontale < partie.Longueur &&
                (partie.Labyrinthe[nouvellePositionVerticale, nouvellePositionHorizontale] == 0 || partie.Labyrinthe[nouvellePositionVerticale, nouvellePositionHorizontale] == 2 ||
                partie.Labyrinthe[nouvellePositionVerticale, nouvellePositionHorizontale] == 3 || partie.Labyrinthe[nouvellePositionVerticale, nouvellePositionHorizontale] == 4 ||
                partie.Labyrinthe[nouvellePositionVerticale, nouvellePositionHorizontale] == 5))
            {
                if (partie.Labyrinthe[nouvellePositionVerticale, nouvellePositionHorizontale] == 2)
                {
                    partie.ChangementClef();
                    partie.Labyrinthe[nouvellePositionVerticale, nouvellePositionHorizontale] = 0;
                    picClef.Image = Properties.Resources.clef;
                }
                if (partie.Labyrinthe[nouvellePositionVerticale, nouvellePositionHorizontale] == 4)
                {
                    partie.RetirerVie();
                    if (partie.Vie == 1)
                    {
                        picCoeur1.Image = Properties.Resources.coeur_vide;
                    }
                    picCoeur2.Image = Properties.Resources.coeur_vide;
                }
                if (partie.Labyrinthe[nouvellePositionVerticale, nouvellePositionHorizontale] == 3 && partie.Clef == true)
                {
                    partie.ChangementPorte();
                    porte = Properties.Resources.porte_ouverte;
                }


                // Déplacement autorisé
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
            for (int r = 0; r < partie.Largeur; r++)
            {
                for (int c = 0; c < partie.Longueur; c++)
                {
                    if (partie.Labyrinthe[r, c] == 4)
                    {
                        ennemieN1.NouvellePosition(r, c);
                    }
                }
            }
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

        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
            touchePresser = false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DeplacerEnnemis();
        }

        private void DeplacerEnnemis()
        {
            int c = ennemieN1.NouvellePositionHorizontale;
            int r = ennemieN1.NouvellePositionVerticale;

            int direction = random.Next(4);
            int nouvellePositionVerticale = r;
            int nouvellePositionHorizontale = c;

            switch (direction)
            {
                case 0: // Haut
                    nouvellePositionVerticale--;
                break;
                case 1: // Bas
                    nouvellePositionVerticale++;
                break;
                case 2: // Gauche
                    nouvellePositionHorizontale--;
                break;
                            case 3: // Droite
                                nouvellePositionHorizontale++;
                                break;
                        }

                        if (nouvellePositionVerticale >= 0 && nouvellePositionVerticale < partie.Largeur &&
                            nouvellePositionHorizontale >= 0 && nouvellePositionHorizontale < partie.Longueur &&
                            partie.Labyrinthe[nouvellePositionVerticale, nouvellePositionHorizontale] == 0)
                        {
                            partie.Labyrinthe[r, c] = 0;
                            partie.Labyrinthe[nouvellePositionVerticale, nouvellePositionHorizontale] = 4;

                            int offsetX = (this.ClientSize.Width - (partie.Longueur * tailleImage)) / 2;
                            int offsetY = (this.ClientSize.Height - (partie.Largeur * tailleImage)) / 2;
                            Rectangle ancienneCellule = new Rectangle(offsetX + c * tailleImage, offsetY + r * tailleImage, tailleImage, tailleImage);
                            Rectangle nouvelleCellule = new Rectangle(offsetX + nouvellePositionHorizontale * tailleImage, offsetY + nouvellePositionVerticale * tailleImage, tailleImage, tailleImage);

                            labyrinthePanel.Invalidate(ancienneCellule);
                            labyrinthePanel.Invalidate(nouvelleCellule);
                ennemieN1.NouvellePosition(nouvellePositionVerticale, nouvellePositionHorizontale);
                        }
                    }
                
            
        
        int ObjetAleatoire()
        {
            Random rnd = new Random();
            int objet = random.Next(1, 3);
            return objet;
        }
    }
}