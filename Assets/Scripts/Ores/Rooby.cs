using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rooby : Ore
{
    void OnEnable()
    {
        numberOfClick = 40;
        oreValue = 2000;
        GameManager.gm.ClickText.text = numberOfClick.ToString();
        GameManager.gm.ore = gameObject;
    }
}
