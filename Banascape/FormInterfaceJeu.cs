using System;
using System.Drawing;
using System.Windows.Forms;

namespace Banascape
{
    public partial class frmInterfaceJeu : Form
    {
        // Declaration des différents objets utilisés par le jeu
        private FormMenuEchap formMenuEchap;
        private System.Windows.Forms.Timer tempsAvantProchainDeplacement;
        private System.Windows.Forms.Timer durerStunt;
        private Partie partie;
        private Ennemi ennemieN1, ennemieN2;
        private Random random = new Random();

        // Declaration des différents attributs utilisés par le jeu
        private int positionVerticaleJoueur = 1;
        private int positionHorizontaleJoueur = 1;
        private int tailleImage;
        private bool touchePresser = false;

        // Declaration des différents images utilisés par le jeu
        private Image mur;
        private Image joueur;
        private Image clef;
        private Image porte;
        private Image ennemie;
        private Image caise;

        // Constructeur de  frmInterfaceJeu : Initialise toutes les valeurs nécessaires au jeu
        // Paramètres :
        // - pseudo: pseudo du joueur
        // - pseudo: difficultés du jeu
        // Valeur retournée : aucune
        public frmInterfaceJeu(string pseudo, bool difficulté)
        {
            InitializeComponent();

            int dimensionVerticale = difficulté ? 15 : 18;
            int dimensionHorizontale = difficulté ? 20 : 25;
            tailleImage = difficulté ? 60 : 50;
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

        // Methode FormInterfaceJeu_KeyDown: associe des actions aux touches pressées
        // Valeur retournée : aucune
        private void FormInterfaceJeu_KeyDown(object sender, KeyEventArgs e)
        {
            //ouverture du menu échappe quand la touche échappe est presser
            if (e.KeyCode == Keys.Escape)
            {
                if (!formMenuEchap.Visible)
                {
                    formMenuEchap.Show();
                }
            }

            //récupération d'un objet si le joueur se trouve sur une caisse et qu'il appuie sur entrées
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

            //si la touche "e" est pressée et que le joueur possède un objet
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
                            partie.AugmenterPoint(50);

                        }
                        if (verifEnnemie(ennemieN2))
                        {
                            durerStunt.Start();
                            partie.ChangementInvincible();
                            ennemieN2.StuntEnnemie();
                            partie.AugmenterPoint(50);


                        }

                        partie.ChangementObjetUtilisé();
                        break;
                }
            }

            //si la touche entrée est pressée, que le joueur possède une clef et se trouve sur une porte
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

        // sous programme verifEnnemie : vérifie si un des ennemis se trouve au tour du joueur dans un rayon d'une case
        // Paramètres :
        // - ennemi: Objet de la classe Ennmie
        // Valeur retournée : bool
        bool verifEnnemie(Ennemi ennemie)
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

        // Methode OnPaint: dessine le labyrinthe dans la fenêtre
        // Valeur retournée : aucune
        private void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int décalageEnX = (this.ClientSize.Width - (partie.Longueur * tailleImage)) / 2;
            int décalageEnY = (this.ClientSize.Height - (partie.Largeur * tailleImage)) / 2;

            Rectangle zoneDessin = e.ClipRectangle;

            for (int verticale = 0; verticale < partie.Largeur; verticale++)
            {
                for (int horizontale = 0; horizontale < partie.Longueur; horizontale++)
                {
                    Rectangle celluleRectangle = new Rectangle(décalageEnX + horizontale * tailleImage, décalageEnY + verticale * tailleImage, tailleImage, tailleImage);

                    if (zoneDessin.IntersectsWith(celluleRectangle))
                    {
                        switch (partie.Labyrinthe[verticale, horizontale])
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

            Rectangle joueurCellule = new Rectangle(décalageEnX + positionHorizontaleJoueur * tailleImage, décalageEnY + positionVerticaleJoueur * tailleImage, tailleImage, tailleImage);
            g.DrawImage(joueur, joueurCellule);
        }

        // sous programme DeplacerJoueur : déplace le joueur en fonction de la touche pressée et verifie si le joueur se trouve sur une clef ou sur un ennemi 
        // Paramètres :
        // - e: touché pressé
        // Valeur retournée : aucune
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

        // sous programme ChargerNouveauLabyrinthe : permet de générer le niveau suivant du jeu
        // Valeur retournée : aucune
        void ChargerNouveauLabyrinthe()
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

            partie.AugmenterPoint(100);

            lblPoint.Text = $"Points : {partie.Point}";
        }

        // sous programme OnKeyUp : remplace la méthode OnkeyUp par cette méthode pour éviter que le joueur puisse se déplacer en maintenant la touche
        // Valeur retournée : aucune
        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
            touchePresser = false;
        }

        // sous programme lancementDeplacementEnnemie : si l'ennemi n'est pas immobilisé, lance l'algo pour le déplacement
        // Valeur retournée : aucune
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

        }

        // sous programme DeplacerEnnemis : déplace l'ennemi en l'algo de recherche en profondeur
        // Paramètres :
        // - ennemi: instance de la class Ennemi
        // Valeur retournée : aucune
        void DeplacerEnnemis(Ennemi ennemi)
        {
            int horizontale = ennemi.NouvellePositionHorizontale;
            int verticale = ennemi.NouvellePositionVerticale;

            int direction = ennemi.DirectionActuelle;
            int nouvellePositionVerticale = verticale;
            int nouvellePositionHorizontale = horizontale;

            bool deplace = false;

            while (!deplace)
            {
                switch (direction)
                {
                    case 0:
                        if (nouvellePositionVerticale - 1 >= 0 && partie.Labyrinthe[nouvellePositionVerticale - 1, horizontale] == 0)
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
                        if (nouvellePositionHorizontale + 1 < partie.Longueur && partie.Labyrinthe[verticale, nouvellePositionHorizontale + 1] == 0)
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
                        if (nouvellePositionVerticale + 1 >= 0 && partie.Labyrinthe[nouvellePositionVerticale + 1, horizontale] == 0)
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
                        if (nouvellePositionHorizontale - 1 < partie.Longueur && partie.Labyrinthe[verticale, nouvellePositionHorizontale - 1] == 0)
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
                partie.Labyrinthe[verticale, horizontale] = 0;
                partie.Labyrinthe[nouvellePositionVerticale, nouvellePositionHorizontale] = 4;

                int offsetX = (this.ClientSize.Width - (partie.Longueur * tailleImage)) / 2;
                int offsetY = (this.ClientSize.Height - (partie.Largeur * tailleImage)) / 2;
                Rectangle ancienneCellule = new Rectangle(offsetX + horizontale * tailleImage, offsetY + verticale * tailleImage, tailleImage, tailleImage);
                Rectangle nouvelleCellule = new Rectangle(offsetX + nouvellePositionHorizontale * tailleImage, offsetY + nouvellePositionVerticale * tailleImage, tailleImage, tailleImage);

                labyrinthePanel.Invalidate(ancienneCellule);
                labyrinthePanel.Invalidate(nouvelleCellule);

                ennemi.NouvellePosition(nouvellePositionVerticale, nouvellePositionHorizontale);
                ennemi.DirectionActuelle = direction;
            }

            if (nouvellePositionVerticale == positionVerticaleJoueur && nouvellePositionHorizontale == positionHorizontaleJoueur)
            {
                degat(ennemi);

            }
        }

        // sous programme ObjetAleatoire : donne un chiffre au hazard entre 1 et 2
        // Valeur retournée : un entier entre 1 et 2
        int ObjetAleatoire()
        {
            int obj = random.Next(1, 3);
            return obj;
        }

        // sous programme RechercheEnemie : recherche dans le labyrinthe les ennemis puis associe leur emplacement aux instances de la classe Ennemi
        // Valeur retournée : un entier entre 1 et 2
        void RechercheEnemie()
        {
            for (int r = 0; r < partie.Largeur; r++)
            {
                for (int c = 0; c < partie.Longueur; c++)
                {
                    if (partie.Labyrinthe[r, c] == 4)
                    {
                        if (ennemieN1 == null)
                            ennemieN1 = new Ennemi(r, c);
                        else if (ennemieN2 == null)
                            ennemieN2 = new Ennemi(r, c);

                    }
                }
            }
        }

        // sous programme degat : retire de la vie au joueur,  affiche les cœurs vides et si le joueur n'a plus de vie, le jeu est fermé et ouvre le form gameover 
        // Valeur retournée : aucune
        void degat(Ennemi ennemie)
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
                    frmPerdu = new frmGameOver(partie.Point, partie.Niveau, partie.Pseudo);

                    // ouverture du Jeu
                    frmPerdu.ShowDialog();
                    this.Close();
                }

            }
        }
        // sous programme degatN1 : retire de la vie au joueur unique si c'est l'ennemiN1,  affiche les cœurs vides et si le joueur n'a plus de vie, le jeu est fermé et ouvre le form gameover 
        // Valeur retournée : aucune
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
                    frmPerdu = new frmGameOver(partie.Point, partie.Niveau, partie.Pseudo);

                    // ouverture du Jeu
                    frmPerdu.ShowDialog();
                    this.Close();
                }

            }
        }

        // sous programme degatN1 : retire de la vie au joueur unique si c'est l'ennemiN2,  affiche les cœurs vides et si le joueur n'a plus de vie, le jeu est fermé et ouvre le form gameover 
        // Valeur retournée : aucune
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

                    frmPerdu = new frmGameOver(partie.Point,partie.Niveau,partie.Pseudo);

                    frmPerdu.ShowDialog();
                    this.Close();
                }

            }
        }

        // sous programme imobilisationEnnmie : désactive le stun sur les ennemis affectés
        // Paramètres :
        // - pseudo: pseudo du joueur
        // - pseudo: difficultés du jeu
        // Valeur retournée : aucune
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
    }

}


