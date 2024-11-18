public class Pieces : GameObject
{
    public int XPos {get; set;}
    public int YPos {get; set;}

    public Pieces(int xPos, int yPos, bool isEliminated)
    {
        XPos = xPos;
        YPos = YPos;
        IsEliminated = false;
    }
}