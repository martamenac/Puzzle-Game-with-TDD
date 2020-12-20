using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorScroll
{
    public List<string> Colors => _colors;
    private List<string> _colors;

    public int ColorLength => _colors.Count;

    public ColorScroll()
    {
        _colors = new List<string>();
    }

    public void InitializeColors (List<string> cellColors)
    {
        _colors = RandomizeList(cellColors);
    }

    private List<string> RandomizeList(List<string> originalList)
    {
        var original = originalList;
        List<string> finalList = new List<string>();

        for (int i = 0; i < originalList.Count; i++)
        {
            int index = Random.Range(0, original.Count);

            finalList.Add(original[index]);
            original.RemoveAt(index);
        }

        return finalList;
    }
}
