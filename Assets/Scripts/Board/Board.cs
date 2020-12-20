using System;
using System.Collections.Generic;

public class Board
{
    private const int COLUMNS_DIMENSION = 0;
    private const int ROWS_DIMENSION = 1;
    
    private readonly int[,] _cells;
    private List<Cell> _squares = new List<Cell>();

    public Board(int width, int height)
    {
        if (width <= 0 || height <= 0)
        {
            throw new Exception();
        }

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
                _squares.Add(new Cell(i, j));
            }
        }
    }
}