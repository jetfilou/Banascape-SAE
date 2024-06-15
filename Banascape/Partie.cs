using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banascape
{
    internal class Partie
    {

        // Propriétés
        private string _pseudo;
        private int _nbVie;
        private bool _clef;
        private int[,] _labyrinthe;
        private int _point;
        private int _longueurLabyrinthe;
        private int _largeurLabyrinthe;

        // Constructeurs
        public Partie(string pseudo, int longueurLabyrinthe, int largeurLabyrinthe)
        {
            _pseudo = pseudo;
            _nbVie = 2;
            _clef = false;
            _point = 0;
            this._largeurLabyrinthe = largeurLabyrinthe;
            this._longueurLabyrinthe = longueurLabyrinthe;

            GenerateurDeLabyrinthe generateur = new GenerateurDeLabyrinthe(longueurLabyrinthe - 2, largeurLabyrinthe - 2);
            generateur.GenerationDuLabyrinthe();
            _labyrinthe = generateur.GetLabyrintheAvecBordures();

        }

        public int[,] Labyrinthe
        {
            get { return _labyrinthe; }
        }
        public int Largeur
        {
            get { return _largeurLabyrinthe; }
        }
        public int Longueur
        {
            get { return _longueurLabyrinthe; }
        }

        public void RetirerVie()
        {
            _nbVie--;
        }
    }
}
    

