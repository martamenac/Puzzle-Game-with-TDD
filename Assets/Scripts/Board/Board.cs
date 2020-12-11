using System.Collections.Generic;

public class Board
{
    private const int COLUMNS_DIMENSION = 0;
    private const int ROWS_DIMENSION = 1;
    
    private readonly int[,] _cells;
    private List<Square> _squares = new List<Square>();

    public Board(int width, int height)
    {
        _cells = new int[width, height];
    }

    public void FillBoard()
    {
        CreateSquares(NumberOfColumns, NumberOfRows);
    }
    
    public int NumberOfColumns => _cells.GetLength(COLUMNS_DIMENSION);
    public int NumberOfRows => _cells.GetLength(ROWS_DIMENSION);
    public int RemainingSquares => _squares.Count;



    private void CreateSquares(int width, int height)
    {
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                _squares.Add(new Square(i, j));
            }
        }
    }
}