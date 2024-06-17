using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void NouvellePosition(int nouvellePositionVertical, int nouvellePositionHorizontale)
        {
            _anciennePositionVerticale  = _positionVerticale;
            _anciennePositionVerticale = _positionHorizontale;

            _positionVerticale = nouvellePositionVertical;
            _positionHorizontale = nouvellePositionHorizontale;
        }
        public void stuntEnnemie()
        {
            _stunt = true;
        }

    }
}
