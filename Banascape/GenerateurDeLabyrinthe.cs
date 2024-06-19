using System.Reflection.Metadata;

namespace Banascape
{
    internal class GenerateurDeLabyrinthe
    {
        // Déclaration des attributs
        private int largeur;
        private int hauteur;
        private int[,] labyrinthe;

        // Constructeur de la classe GenerateurDeLabyrinthe
        // Définissent les tailles du labyrinthe
        // Paramètre :
        // largeur : entier(largeur du labyrinthe)
        // hauteur : entier(longueur du labyrinthe)
        public GenerateurDeLabyrinthe(int largeur, int hauteur)
        {
            this.largeur = largeur;
            this.hauteur = hauteur;
            labyrinthe = new int[hauteur, largeur];
        }

        // Procédure GenerationDuLabyrinthe 
        // Défini tout le labyrinthe comme des murs puis appelle la procédure (rechercheEnProfondeur) afin de créer le labyrinthe 
        // ensuite appelle des procédures faisant apparaitre les items et les ennemis dans le labyrinthe
        // Paramètre : Aucun
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
            PassageAleatoire();
            AjouterClef();
            AjouterEnemie();
            AjouterEnemie();
            AjouterCaise();
            labyrinthe[hauteur - 1, largeur - 1] = 3;
        }

        // Procédure RechercheEnProfondeur
        // Appel de la procédure (Melange)
        // Permets des créer un labyrinthe complètement aléatoire et different à chaque iteration
        // Paramètre :
        //      Ligne Debut : entier (ligne où commencera le labyrinthe)
        //      Colonne Debut : entier (colonne où commencera le labyrinthe)
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

        // Procédure TestePosition
        // Permets de vérifier si le positon se situe bien dans le labyrinthe et n'est pas hors limite
        // Paramètre :
        //      ligne : entier
        //      colonne : entier
        private bool TestePosition(int ligne, int colone)
        {
            return ligne >= 0 && ligne < hauteur && colone >= 0 && colone < largeur;
        }

        // Procédure Mélange
        // Mélange un tableau à une dimension pour avoir des directions aléatoires lors de la création du labyrinthe
        // Paramètre :
        //      tableau a 1 dimension : entier (stocke les 4 directions possibles : haut, bas, gauche, droite)
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

        // Fonction Getlabyrinthe 
        // Retourne le labyrinthe généré
        // Paramètre : aucun
        public int[,] GetLabyrinthe()
        {
            return labyrinthe;
        }

        // Procédure AjouterClef
        // Mets dans 1 liste toute les positions vide
        // puis sélectionne 1 aléatoirement pour y déposer la clef 
        // Paramètre : aucun
        public void AjouterClef()
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

        // Procédure AjouterEnnemie
        // Mets dans 1 liste toute les positions vide
        // puis sélectionne 1 aléatoirement pour y déposer l' ennemi
        // Paramètre : aucun
        public void AjouterEnemie()
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
                labyrinthe[positionAleatoire.Item1, positionAleatoire.Item2] = 4;
            }
        }

        // Procédure AjouterCaise
        // Mets dans 1 liste toute les positions vide
        // puis sélectionne 1 aléatoirement pour y déposer la caisse
        // Paramètre : aucun
        public void AjouterCaise()
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
                labyrinthe[positionAleatoire.Item1, positionAleatoire.Item2] = 5;
            }
        }

        // Procédure PassageAleatoire
        // supprime 8 murs aléatoires dans le labyrinthe afin de créer plusieurs passages possibles
        // Paramètre : aucun
        public void PassageAleatoire()
        {
            for (int i = 0; i < 8; i++)
            {
                int hauteurAleatoire = 0, largeurAleatoire = 0, minVal = 0, maxVal = hauteur;
                do
                {
                    Random random = new Random();
                    hauteurAleatoire = random.Next(minVal, maxVal);
                    largeurAleatoire = random.Next(minVal, maxVal);
                } while (labyrinthe[hauteurAleatoire, largeurAleatoire] != 1);

                labyrinthe[hauteurAleatoire, largeurAleatoire] = 0;
            }
        }

        // fonction GetLabyrintheAvecBordures
        // Ajoute des bordures au labyrinthe
        // retourne le labyrinthe 
        // Paramètre : aucun
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
