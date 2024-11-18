public class GameBoard
{
    public int[,] GameBoardArray {get; set;}

    public GameBoard(int rows, int columns)
    {
        GameBoardArray = new int[rows, columns];
    }
}