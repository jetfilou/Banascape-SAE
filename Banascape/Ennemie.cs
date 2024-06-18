public class Ennemie
{
    public int PositionVerticale { get; set; }
    public int PositionHorizontale { get; set; }

    public Ennemie(int positionVerticale, int positionHorizontale)
    {
        PositionVerticale = positionVerticale;
        PositionHorizontale = positionHorizontale;
    }
}