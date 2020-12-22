using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell
{
    //public string color;
    private Color _color;

    public Color CellColor => _color;

    public Cell()
    {

    }

    public Cell(Color color)
    {
        _color = color;
    }
}
