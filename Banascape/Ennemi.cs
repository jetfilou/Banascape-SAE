using System;

namespace Banascape
{
    internal class Ennemi
    {

        //Déclaration des attributs
        private int _positionVerticale;
        private int _positionHorizontale;
        private int _anciennePositionVerticale;
        private int _anciennePositionHorizontale;
        private bool _stunt;
        private int _directionActuelle;

        // Constructeur de la classe Ennemie
        // paramètre :
        //    positionVertical : entier, la position verticale initiale de l'ennemi
        //    positionHorizontale : entier, la position horizontale initiale de l'ennemi
        public Ennemi(int positionVertical, int positionHorizontale)
        {
            _positionVerticale = positionVertical;
            _positionHorizontale = positionHorizontale;
            _stunt = false;
            _directionActuelle = 0;
        }

        // Propriétés pouir acceder aux position verticale et horizontale  et a la direction
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

        //Stock les position actuel en ancienne position puis récupère la nouvelle position de l'ennemi
        //paramètre : 
        //    nouvellePositionVertical : entier 
        //    nouvellePositionHorizontale : entier
        public void NouvellePosition(int nouvellePositionVertical, int nouvellePositionHorizontale)
        {
            _anciennePositionVerticale = _positionVerticale;
            _anciennePositionHorizontale = _positionHorizontale;

            _positionVerticale = nouvellePositionVertical;
            _positionHorizontale = nouvellePositionHorizontale;
        }

        //permet de modifier la valeur de stun passant de vrai a faux après chaque appel de cet procedure
        //paramètre : aucun 
        public void StuntEnnemie()
        {
            _stunt = !_stunt;
        }
    }
}