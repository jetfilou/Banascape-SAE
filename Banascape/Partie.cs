﻿using System;
using System.Data.SqlClient;

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
        private bool _objetInventaire;
        private int _typeObjet;
        private bool _invincible;

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

        public void ChangementClef()
        {
            _clef = !_clef;
        }

        public void ChangementPorte()
        {
            _porte = !_porte;
        }

        public void RetirerVie()
        {
            _nbVie--;
        }
        public void AjoutrerVie()
        {
            _nbVie++;
        }

        public void AugmenterPoint()
        {
            _point += 100;
        }
        public void ChangementObjetRamaser(int obj)
        {
            _objetInventaire = true;
            _typeObjet = obj;

        }
        public void ChangementObjetUtilisé()
        {
            _objetInventaire = false;
            _typeObjet = 0;

        }
        public void ChangementInvincible()
        {
            _invincible = !_invincible;
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