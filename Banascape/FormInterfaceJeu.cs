﻿using System;
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
        private Ennemie ennemieN1, ennemieN2;
        private Random random = new Random();

        private int positionVerticaleJoueur = 1;
        private int positionHorizontaleJoueur = 1;
        private const int tailleImage = 60;

        private bool touchePresser = false;

        private Image mur;
        private Image joueur;
        private Image clef;
        private Image porte;
        private Image ennemie;
        private Image caise;

        public frmInterfaceJeu(string pseudo, bool diff)
        {
            InitializeComponent();

            int dimensionVerticale = diff ? 15 : 18;
            int dimensionHorizontale = diff ? 20 : 25;

            partie = new Partie(pseudo, dimensionHorizontale, dimensionVerticale);
            this.ClientSize = new Size(tailleImage * partie.Longueur, tailleImage * partie.Largeur);

            formMenuEchap = new FormMenuEchap();
            this.KeyDown += new KeyEventHandler(FormInterfaceJeu_KeyDown);
            this.KeyPreview = true;

            mur = Properties.Resources.mur;
            clef = Properties.Resources.clef;
            porte = Properties.Resources.porte_refaite;
            caise = Properties.Resources.caisse;
            ennemie = Properties.Resources.ennemi;
            joueur = Properties.Resources.Banane;
            picClef.Image = Properties.Resources.clef_vide;

            tempsAvantProchainDeplacement = new System.Windows.Forms.Timer();
            tempsAvantProchainDeplacement.Interval = 2000;
            tempsAvantProchainDeplacement.Tick += lancementDeplacementEnnemie;
            tempsAvantProchainDeplacement.Start();

            durerStunt = new System.Windows.Forms.Timer();
            durerStunt.Interval = 20000;
            durerStunt.Tick += imobilisationEnnmie;

            RechercheEnemie();
        }


        private void imobilisationEnnmie(object sender, EventArgs e)
        {
            partie.ChangementInvincible();
            if (ennemieN1.Stun == true)
            {
                ennemieN1.StuntEnnemie();
            }
            if (ennemieN2.Stun == true)
            {
                ennemieN2.StuntEnnemie();
            }

            durerStunt.Stop();
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
                        if (partie.Vie < 3)
                        {
                            partie.AjoutrerVie();
                            if (partie.Vie == 2)
                                picCoeur1.Image = Properties.Resources.coeur_plein;
                            else if (partie.Vie == 3)
                                picCoeur2.Image = Properties.Resources.coeur_plein;
                            partie.ChangementObjetUtilisé();
                            picObjet.Image = null;
                        }
                        break;
                    case 2:
                        picObjet.Image = null;
                        if (verifEnnemie(ennemieN1))
                        {
                            durerStunt.Start();
                            partie.ChangementInvincible();
                            ennemieN1.StuntEnnemie();
                        }
                        if (verifEnnemie(ennemieN2))
                        {
                            durerStunt.Start();
                            partie.ChangementInvincible();
                            ennemieN2.StuntEnnemie();

                        }

                        partie.ChangementObjetUtilisé();
                        break;
                }
            }

            if (e.KeyCode == Keys.Enter && partie.Labyrinthe[positionVerticaleJoueur, positionHorizontaleJoueur] == 3 && partie.Porte)
            {
                ChargerNouveauLabyrinthe();
            }
            else
            {
                if (e.KeyCode == Keys.Z || e.KeyCode == Keys.Q || e.KeyCode == Keys.S || e.KeyCode == Keys.D ||
                    e.KeyCode == Keys.Right || e.KeyCode == Keys.Left || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
                {
                    DeplacerJoueur(e);
                }
            }
        }

        bool verifEnnemie(Ennemie ennemie)
        {
            if ((positionVerticaleJoueur + 1 == ennemie.NouvellePositionVerticale && positionHorizontaleJoueur == ennemie.NouvellePositionHorizontale) ||
               (positionVerticaleJoueur + 1 == ennemie.NouvellePositionVerticale && positionHorizontaleJoueur + 1 == ennemie.NouvellePositionHorizontale) ||
               (positionVerticaleJoueur + 1 == ennemie.NouvellePositionVerticale && positionHorizontaleJoueur - 1 == ennemie.NouvellePositionHorizontale) ||
               (positionVerticaleJoueur == ennemie.NouvellePositionVerticale && positionHorizontaleJoueur + 1 == ennemie.NouvellePositionHorizontale) ||
               (positionVerticaleJoueur == ennemie.NouvellePositionVerticale && positionHorizontaleJoueur - 1 == ennemie.NouvellePositionHorizontale) ||
               (positionVerticaleJoueur - 1 == ennemie.NouvellePositionVerticale && positionHorizontaleJoueur == ennemie.NouvellePositionHorizontale) ||
               (positionVerticaleJoueur - 1 == ennemie.NouvellePositionVerticale && positionHorizontaleJoueur + 1 == ennemie.NouvellePositionHorizontale) ||
               (positionVerticaleJoueur - 1 == ennemie.NouvellePositionVerticale && positionHorizontaleJoueur - 1 == ennemie.NouvellePositionHorizontale))
            {
                return true;
            }
            return false;
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

            if (nouvellePositionVerticale >= 0 && nouvellePositionVerticale < partie.Largeur &&
     nouvellePositionHorizontale >= 0 && nouvellePositionHorizontale < partie.Longueur &&
     (partie.Labyrinthe[nouvellePositionVerticale, nouvellePositionHorizontale] == 0 ||
      partie.Labyrinthe[nouvellePositionVerticale, nouvellePositionHorizontale] == 2 ||
      partie.Labyrinthe[nouvellePositionVerticale, nouvellePositionHorizontale] == 3 ||
      partie.Labyrinthe[nouvellePositionVerticale, nouvellePositionHorizontale] == 4 ||
      partie.Labyrinthe[nouvellePositionVerticale, nouvellePositionHorizontale] == 5 ||
      partie.Labyrinthe[nouvellePositionVerticale, nouvellePositionHorizontale] == 6))
            {
                if (partie.Labyrinthe[nouvellePositionVerticale, nouvellePositionHorizontale] == 2)
                {
                    partie.ChangementClef();
                    partie.Labyrinthe[nouvellePositionVerticale, nouvellePositionHorizontale] = 0;
                    picClef.Image = Properties.Resources.clef;
                }
                if (partie.Labyrinthe[nouvellePositionVerticale, nouvellePositionHorizontale] == 4)
                {
                    if (nouvellePositionVerticale == ennemieN1.NouvellePositionVerticale && nouvellePositionHorizontale == ennemieN1.NouvellePositionHorizontale)
                    {
                        degatN1();
                    }
                    if (nouvellePositionVerticale == ennemieN2.NouvellePositionVerticale && nouvellePositionHorizontale == ennemieN2.NouvellePositionHorizontale)
                    {
                        degatN2();
                    }
                }
                if (partie.Labyrinthe[nouvellePositionVerticale, nouvellePositionHorizontale] == 3 && partie.Porte)
                {
                    partie.ChangementPorte();
                    porte = Properties.Resources.porte_ouverte;
                }

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

            ennemieN1 = null;
            ennemieN2 = null;

            RechercheEnemie();

            labyrinthePanel.Invalidate();

            lblNiveau.Text = $"Niveau : {partie.Niveau}";

            porte = Properties.Resources.porte_refaite;
            picClef.Image = Properties.Resources.clef_vide;

            partie.AugmenterPoint();

            lblPoint.Text = $"Points : {partie.Point}";
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
            touchePresser = false;
        }

        private void lancementDeplacementEnnemie(object sender, EventArgs e)
        {
            if (ennemieN1.Stun == false)
            {
                DeplacerEnnemis(ennemieN1);
            }
            if (ennemieN2.Stun == false)
            {
                DeplacerEnnemis(ennemieN2);
            }
            //if (ennemieN3.Stun == false)
            //{
            //    DeplacerEnnemis(ennemieN3);
            //}
        }

        private void DeplacerEnnemis(Ennemie ennemie)
        {
            int c = ennemie.NouvellePositionHorizontale;
            int r = ennemie.NouvellePositionVerticale;

            int direction = ennemie.DirectionActuelle;
            int nouvellePositionVerticale = r;
            int nouvellePositionHorizontale = c;

            bool deplace = false;

            while (!deplace)
            {
                switch (direction)
                {
                    case 0:
                        if (nouvellePositionVerticale - 1 >= 0 && partie.Labyrinthe[nouvellePositionVerticale - 1, c] == 0)
                        {
                            nouvellePositionVerticale--;
                            direction = 3 % 4;
                            deplace = true;
                        }
                        else
                        {
                            direction = (direction + 1) % 4;
                        }
                        break;
                    case 1:
                        if (nouvellePositionHorizontale + 1 < partie.Longueur && partie.Labyrinthe[r, nouvellePositionHorizontale + 1] == 0)
                        {
                            nouvellePositionHorizontale++;
                            direction = (direction - 1) % 4;
                            deplace = true;
                        }
                        else
                        {
                            direction = (direction + 1) % 4;
                        }
                        break;
                    case 2:
                        if (nouvellePositionVerticale + 1 >= 0 && partie.Labyrinthe[nouvellePositionVerticale + 1, c] == 0)
                        {
                            nouvellePositionVerticale++;
                            direction = (direction - 1) % 4;
                            deplace = true;
                        }
                        else
                        {
                            direction = (direction + 1) % 4;
                        }
                        break;
                    case 3:
                        if (nouvellePositionHorizontale - 1 < partie.Longueur && partie.Labyrinthe[r, nouvellePositionHorizontale - 1] == 0)
                        {
                            nouvellePositionHorizontale--;
                            direction = (direction - 1) % 4;
                            deplace = true;
                        }
                        else
                        {
                            direction = (direction + 1) % 4;
                        }
                        break;
                }
            }

            if (nouvellePositionVerticale >= 0 && nouvellePositionVerticale < partie.Largeur &&
                nouvellePositionHorizontale >= 0 && nouvellePositionHorizontale < partie.Longueur &&
                (partie.Labyrinthe[nouvellePositionVerticale, nouvellePositionHorizontale] == 0 || partie.Labyrinthe[nouvellePositionVerticale, nouvellePositionHorizontale] == 4))
            {
                partie.Labyrinthe[r, c] = 0;
                partie.Labyrinthe[nouvellePositionVerticale, nouvellePositionHorizontale] = 4;

                int offsetX = (this.ClientSize.Width - (partie.Longueur * tailleImage)) / 2;
                int offsetY = (this.ClientSize.Height - (partie.Largeur * tailleImage)) / 2;
                Rectangle ancienneCellule = new Rectangle(offsetX + c * tailleImage, offsetY + r * tailleImage, tailleImage, tailleImage);
                Rectangle nouvelleCellule = new Rectangle(offsetX + nouvellePositionHorizontale * tailleImage, offsetY + nouvellePositionVerticale * tailleImage, tailleImage, tailleImage);

                labyrinthePanel.Invalidate(ancienneCellule);
                labyrinthePanel.Invalidate(nouvelleCellule);

                ennemie.NouvellePosition(nouvellePositionVerticale, nouvellePositionHorizontale);
                ennemie.DirectionActuelle = direction;
            }

            if (nouvellePositionVerticale == positionVerticaleJoueur && nouvellePositionHorizontale == positionHorizontaleJoueur)
            {
                degat(ennemie);

            }
        }

        int ObjetAleatoire()
        {
            int obj = random.Next(1, 3);
            return obj;
        }

        void RechercheEnemie()
        {
            for (int r = 0; r < partie.Largeur; r++)
            {
                for (int c = 0; c < partie.Longueur; c++)
                {
                    if (partie.Labyrinthe[r, c] == 4)
                    {
                        if (ennemieN1 == null)
                            ennemieN1 = new Ennemie(r, c);
                        else if (ennemieN2 == null)
                            ennemieN2 = new Ennemie(r, c);

                    }
                }
            }
        }
        void degat(Ennemie ennemie)
        {
            if (ennemie.Stun == false)
            {
                partie.RetirerVie();
                if (partie.Vie == 1)
                {
                    picCoeur1.Image = Properties.Resources.coeur_vide;
                }
                picCoeur2.Image = Properties.Resources.coeur_vide;
                if (partie.Vie == 0)
                {
                    frmGameOver frmPerdu;
                    // instanciation d'un objet de type FormInterfaceJeu 
                    frmPerdu = new frmGameOver();

                    // ouverture du Jeu
                    frmPerdu.Show();
                    this.Close();
                }

            }



        }
        void degatN1()
        {
            if (ennemieN1.Stun == false)
            {
                partie.RetirerVie();
                if (partie.Vie == 1)
                {
                    picCoeur1.Image = Properties.Resources.coeur_vide;
                }
                picCoeur2.Image = Properties.Resources.coeur_vide;
                if (partie.Vie == 0)
                {
                    frmGameOver frmPerdu;
                    // instanciation d'un objet de type FormInterfaceJeu 
                    frmPerdu = new frmGameOver();

                    // ouverture du Jeu
                    frmPerdu.Show();
                    this.Close();
                }

            }
        }
        void degatN2()
        {
            if (ennemieN2.Stun == false)
            {
                partie.RetirerVie();
                if (partie.Vie == 1)
                {
                    picCoeur1.Image = Properties.Resources.coeur_vide;
                }
                picCoeur2.Image = Properties.Resources.coeur_vide;
                if (partie.Vie == 0)
                {
                    frmGameOver frmPerdu;
                    // instanciation d'un objet de type FormInterfaceJeu 
                    frmPerdu = new frmGameOver();

                    // ouverture du Jeu
                    frmPerdu.Show();
                    this.Close();
                }

            }
        }
    }
}


