using System;

namespace Banascape
{
    internal class Ennemi
    {
        private bool _etat;
        private int _positionVerticale;
        private int _positionHorizontale;
        private int _anciennePositionVerticale;
        private int _anciennePositionHorizontale;
        private bool _stunt;
        private int _directionActuelle; 

        public Ennemi(int positionVertical, int positionHorizontale)
        {
            _positionVerticale = positionVertical;
            _positionHorizontale = positionHorizontale;
            _etat = true;
            _stunt = false;
            _directionActuelle = 0; 
        }

        public int AnciennePositionVerticale => _anciennePositionVerticale;
        public int AnciennePositionHorizontale => _anciennePositionHorizontale;
        public int NouvellePositionVerticale => _positionVerticale;
        public int NouvellePositionHorizontale => _positionHorizontale;
        public int DirectionActuelle
        {
            get => _directionActuelle;
            set => _directionActuelle = value;
        }
        public bool Stun => _stunt;
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
    }
}


     