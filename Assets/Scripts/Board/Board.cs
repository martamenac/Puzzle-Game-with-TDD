using System;
using System.Collections.Generic;

public class Board
{
    private const int COLUMNS_DIMENSION = 0;
    private const int ROWS_DIMENSION = 1;

    private readonly Cell[,] _cells;

    public int NumberOfColumns => _cells.GetLength(COLUMNS_DIMENSION);
    public int NumberOfRows => _cells.GetLength(ROWS_DIMENSION);

    public Board(int width, int height)
    {
        if (width <= 0 || height <= 0)
        {
            throw new Exception();
        }

        _cells = new Cell[width, height];
    }

    public void FillBoard()
    {
        CreateCells(NumberOfColumns, NumberOfRows);
    }

    
    private void CreateCells(int width, int height)
    {
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                _cells[i, j] = new Cell();
            }
        }
    }
}