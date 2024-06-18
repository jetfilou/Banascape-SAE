using System;

namespace Banascape
{
    internal class Ennemie
    {
        private bool _etat;
        private int _positionVerticale;
        private int _positionHorizontale;
        private int _anciennePositionVerticale;
        private int _anciennePositionHorizontale;
        private bool _stunt;
        private int[,] _labyrinthe;


        public Ennemie(int positionVertical, int positionHorizontale)
        {
            _positionVerticale = positionVertical;
            _positionHorizontale = positionHorizontale;
            _etat = true;
            _stunt = false;
        }

        public int AnciennePositionVerticale => _anciennePositionVerticale;
        public int AnciennePositionHorizontale => _anciennePositionHorizontale;
        public int NouvellePositionVerticale => _positionVerticale;
        public int NouvellePositionHorizontale => _positionHorizontale;
        public bool Stun => _stunt;
        public int[,] Labyrinthe => _labyrinthe;

        public void NouvellePosition(int nouvellePositionVertical, int nouvellePositionHorizontale)
        {
            _anciennePositionVerticale = _positionVerticale;
            _anciennePositionHorizontale = _positionHorizontale;

            _positionVerticale = nouvellePositionVertical;
            _positionHorizontale = nouvellePositionHorizontale;
        }

        public void StuntEnnemie()
        {
            _stunt = !_stunt;
        }
        public void LabyrintheEnnemi(int[,] labyrinthe)
        {
            _labyrinthe = labyrinthe;
        }

        public void LabyrintheEnnemiChangementCasse(int verticale, int horizontale, int val)
        {
            _labyrinthe[verticale, horizontale]= val;
        }
        ~Ennemie() { }
    }
}
