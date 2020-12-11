using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colors : MonoBehaviour
{
    public readonly Dictionary<string, string> colors = new Dictionary<string, string>();

    private void Awake()
    {
        colors.Add("Ghost White", "f3f3f7");
        colors.Add("Paradise Pink","ef476f");
        colors.Add("Orange Yellow Crayola","ffd166");
        colors.Add("Caribbean Green","06d6a0");
        colors.Add("Blue NCS","118ab2");
        colors.Add("Midnight Green Eagle Green","073b4c");
        colors.Add("Raisin Black","25272d");
    }

}


