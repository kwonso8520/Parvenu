using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sapphire : Ore
{
    void OnEnable()
    {
        numberOfClick = 60;
        oreValue = 5000;
        GameManager.gm.ClickText.text = numberOfClick.ToString();
        GameManager.gm.ore = gameObject;
    }
}
