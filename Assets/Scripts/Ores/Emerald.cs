using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emerald : Ore
{
    void OnEnable()
    {
        numberOfClick = 70;
        oreValue = 7000;
        GameManager.gm.ClickText.text = numberOfClick.ToString();
        GameManager.gm.ore = gameObject;
    }
}
