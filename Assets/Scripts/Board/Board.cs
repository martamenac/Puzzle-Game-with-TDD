public class Board
{
    private const int COLUMNS_DIMENSION = 0;
    private const int ROWS_DIMENSION = 1;
    
    private readonly int[,] _cells;
    public Board(int width, int height)
    {
        _cells = new int[width, height];
    }

    
    public int NumberOfColumns => _cells.GetLength(COLUMNS_DIMENSION);
    public int NumberOfRows => _cells.GetLength(ROWS_DIMENSION);

}