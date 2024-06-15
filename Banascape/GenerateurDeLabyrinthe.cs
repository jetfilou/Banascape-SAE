using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banascape
{
    internal class GenerateurDeLabyrinthe
    {
        private int largeur;
        private int hauteur;
        private int[,] labyrinthe;

        // Définie la taille du labyrinthe (constructeur)
        public GenerateurDeLabyrinthe(int largeur, int hauteur)
        {
            this.largeur = largeur;
            this.hauteur = hauteur;
            labyrinthe = new int[hauteur, largeur];
        }

        // Définie tous les cases comme des murs et appelle la fonction de recherche en profondeur
        public void GenerationDuLabyrinthe()
        {
            for (int i = 0; i < hauteur; i++)
            {
                for (int j = 0; j < largeur; j++)
                {
                    labyrinthe[i, j] = 1;
                }
            }

            RechercheEnProfondeur(0, 0);
            AjouterDeux();
            labyrinthe[hauteur - 1, largeur - 2] = 3;
        }

        // Recherche en profondeur
        private void RechercheEnProfondeur(int ligneDebut, int coloneDebut)
        {
            labyrinthe[ligneDebut, coloneDebut] = 0;

            int[] directions = { 1, 2, 3, 4 };
            Melange(directions);

            foreach (int direction in directions)
            {
                int nouvelleLigne = ligneDebut;
                int nouvelleColone = coloneDebut;

                if (direction == 1) { nouvelleLigne -= 2; } // en haut
                if (direction == 2) { nouvelleLigne += 2; } // en bas
                if (direction == 3) { nouvelleColone -= 2; } // à gauche
                if (direction == 4) { nouvelleColone += 2; } // à droite

                if (TestePosition(nouvelleLigne, nouvelleColone) && labyrinthe[nouvelleLigne, nouvelleColone] == 1)
                {
                    int cheminLigne = ligneDebut + (nouvelleLigne - ligneDebut) / 2;
                    int cheminColone = coloneDebut + (nouvelleColone - coloneDebut) / 2;
                    labyrinthe[cheminLigne, cheminColone] = 0;
                    RechercheEnProfondeur(nouvelleLigne, nouvelleColone);
                }
            }
        }

        // Vérifie si la position se trouve dans le labyrinthe
        private bool TestePosition(int ligne, int colone)
        {
            return ligne >= 0 && ligne < hauteur && colone >= 0 && colone < largeur;
        }

        // Mélange un tableau en une dimension
        private void Melange(int[] array)
        {
            Random rnd = new Random();
            for (int i = array.Length - 1; i > 0; i--)
            {
                int randomIndex = rnd.Next(i + 1);
                int temp = array[i];
                array[i] = array[randomIndex];
                array[randomIndex] = temp;
            }
        }

        // Retourne le labyrinthe généré
        public int[,] GetLabyrinthe()
        {
            return labyrinthe;
        }

        public void AjouterDeux()
        {
            List<Tuple<int, int>> positionsValides = new List<Tuple<int, int>>();

            for (int i = 0; i < hauteur; i++)
            {
                for (int j = 0; j < largeur; j++)
                {
                    if (labyrinthe[i, j] == 0 && (Math.Abs(i - 1) + Math.Abs(j - 1)) > 3)
                    {
                        positionsValides.Add(new Tuple<int, int>(i, j));
                    }
                }
            }

            if (positionsValides.Count > 0)
            {
                Random rnd = new Random();
                var positionAleatoire = positionsValides[rnd.Next(positionsValides.Count)];
                labyrinthe[positionAleatoire.Item1, positionAleatoire.Item2] = 2;
            }
        }

        // Retourne le labyrinthe avec bordures de 1
        public int[,] GetLabyrintheAvecBordures()
        {
            int[,] labyrintheAvecBordures = new int[hauteur + 2, largeur + 2];

            // Ajouter des bordures
            for (int i = 0; i < hauteur + 2; i++)
            {
                for (int j = 0; j < largeur + 2; j++)
                {
                    if (i == 0 || i == hauteur + 1 || j == 0 || j == largeur + 1)
                    {
                        labyrintheAvecBordures[i, j] = 1;
                    }
                    else
                    {
                        labyrintheAvecBordures[i, j] = labyrinthe[i - 1, j - 1];
                    }
                }
            }

            return labyrintheAvecBordures;
        }
    }
}
