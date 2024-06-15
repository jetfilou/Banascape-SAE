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
        private bool _porte;
        private int _niveau;

        // Constructeurs
        public Partie(string pseudo, int longueurLabyrinthe, int largeurLabyrinthe)
        {
            _pseudo = pseudo;
            _nbVie = 3;
            _clef = false;
            _point = 0;
            this._largeurLabyrinthe = largeurLabyrinthe;
            this._longueurLabyrinthe = longueurLabyrinthe;
            _porte = false;
            _niveau = 1;

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
        public bool Clef
        {
            get { return _clef; }
        }
        public bool Porte
        {
            get { return _clef; }
        }
        public int Niveau
        {
            get { return _niveau; }
        }
        public int Point
        {
            get { return _point; }
        }
        public int Vie
        {
            get { return _nbVie; }
        }
        public void ChangementClef()
        {
            _clef = _clef !=true ? true : false;
        }
        public void ChangementPorte()
        {
            _porte = _porte != true ? true : false;
        }

        public void RetirerVie()
        {
            _nbVie--;
        }
        public void AugmenterPoint()
        {
            _point=_point+100;
        }
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
    

