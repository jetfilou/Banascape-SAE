public class Partie
{
    public int Largeur { get; }
    public int Longueur { get; }
    public int[,] Labyrinthe { get; private set; }
    public bool Porte { get; private set; }
    public bool Clef { get; private set; }
    public bool Objet { get; private set; }
    public int TypeObjet { get; private set; }
    public bool Invincible { get; private set; }

    private Random random = new Random();

    public Partie(string pseudo, int largeur, int longueur)
    {
        Largeur = largeur;
        Longueur = longueur;
        Labyrinthe = new int[largeur, longueur];
        ChargerLabyrinthe();
    }

    private void ChargerLabyrinthe()
    {
        for (int i = 0; i < Largeur; i++)
        {
            for (int j = 0; j < Longueur; j++)
            {
                Labyrinthe[i, j] = random.Next(6); 
            }
        }
    }

    public void ChargementLabyrinthe()
    {
        ChargerLabyrinthe();
    }

    public void ChangementVie(int vie)
    {
        // Implémenter la logique pour changer la vie du joueur
    }

    public void ChangementPorte()
    {
        Porte = !Porte;
    }

    public void ChangementClef()
    {
        Clef = !Clef;
    }

    public void ChangementObjet()
    {
        Objet = !Objet;
    }

    public void ChangementObjetRamaser(int type)
    {
        TypeObjet = type;
        ChangementObjet();
    }

    public void ChangementInvincible()
    {
        Invincible = !Invincible;
    }
}
