using System;
using System.Data.SqlClient;

namespace Banascape
{
    internal class Partie
    {
        // Déclaration des attributs
        private string _pseudo;
        private int _nbVie;
        private bool _clef;
        private int[,] _labyrinthe;
        private int _point;
        private int _longueurLabyrinthe;
        private int _largeurLabyrinthe;
        private bool _porte;
        private int _niveau;
        private bool _objetInventaire;
        private int _typeObjet;
        private bool _invincible;

        // Constructeur de la class Partie 
        // Appel à la class GenerateurDeLabyrinthe
        // Paramètre ;
        //      pseudo : chaine de caractère (pseudo du joueur actuel)
        //      longueurlabyrinthe, largeurlabyrinthe : entier (dimension du labyrinthe)
        public Partie(string pseudo, int longueurLabyrinthe, int largeurLabyrinthe)
        {
            _pseudo = pseudo;
            _nbVie = 3;
            _clef = false;
            _point = 0;
            _largeurLabyrinthe = largeurLabyrinthe;
            _longueurLabyrinthe = longueurLabyrinthe;
            _porte = false;
            _niveau = 1;
            _objetInventaire = false;
            _typeObjet = 0;
            _invincible = false;
            GenerateurDeLabyrinthe generateur = new GenerateurDeLabyrinthe(longueurLabyrinthe - 2, largeurLabyrinthe - 2);
            generateur.GenerationDuLabyrinthe();
            _labyrinthe = generateur.GetLabyrintheAvecBordures();
        }


        // ensemble des gets
        public int[,] Labyrinthe => _labyrinthe;
        public int Largeur => _largeurLabyrinthe;
        public int Longueur => _longueurLabyrinthe;
        public bool Clef => _clef;
        public bool Porte => _clef;
        public int Niveau => _niveau;
        public int Point => _point;
        public int Vie => _nbVie;
        public int TypeObjet => _typeObjet;
        public bool Objet => _objetInventaire;
        public bool Invincible => _invincible;
        public string Pseudo => _pseudo;

        // Procédure ChangementClef
        // change l'état de clef en fonction de si elle a été ramassée ou non
        // Paramètre : aucun
        public void ChangementClef()
        {
            _clef = !_clef;
        }

        // Procédure ChangementPorte
        // change l'état de Porte en fonction de si la clef a été ramassée ou non
        // Paramètre : aucun
        public void ChangementPorte()
        {
            _porte = !_porte;
        }

        // Procédure RetirerVie
        // Baisse la valeur de nbVie de 1
        // Paramètre : aucun
        public void RetirerVie()
        {
            _nbVie--;
        }

        // Procédure AjoutrerVie
        // Augmente la valeur de nbVie de 1
        // Paramètre : aucun
        public void AjoutrerVie()
        {
            _nbVie++;
        }

        // Procédure AugmenterPoint
        // Augmente la valeur de point de 100
        // Paramètre : aucun
        public void AugmenterPoint(int pointAjouter)
        {
            _point += pointAjouter;
        }

        // Procédure ChangementObjetRamasser
        // Change la valeur d'objetInventaire en True
        // et définit le type de l'objet en fonction du paramètre 
        // Paramètre :
        //      Obj : entier (nombre faisant référence a different objet)
        public void ChangementObjetRamaser(int obj)
        {
            _objetInventaire = true;
            _typeObjet = obj;

        }

        // Procédure ChangementObjetUtilisé
        // Change la valeur d'objetInventaire en False
        // et définit le type de l'objet à 0
        // Paramètre : aucun
        public void ChangementObjetUtilisé()
        {
            _objetInventaire = false;
            _typeObjet = 0;

        }

        // Procédure ChangementInvicible
        // Change l'état de invincible après chaque appel
        // Paramètre : aucun
        public void ChangementInvincible()
        {
            _invincible = !_invincible;
        }

        // Procédure chargerNouveauLabyrinthe
        // Appel de la class GenerateurDeLabyrinthe
        // Redéfinis les valeurs de clef et porte à false 
        // augmente de 1 la valeur de niveau
        // Paramètre : aucun
        public void ChargerNouveauLabyrinthe()
        {
            GenerateurDeLabyrinthe generateur = new GenerateurDeLabyrinthe(_longueurLabyrinthe - 2, _largeurLabyrinthe - 2);
            generateur.GenerationDuLabyrinthe();
            _labyrinthe = generateur.GetLabyrintheAvecBordures();
            _clef = false;
            _porte = false;
            _niveau++;
        }

    }
}