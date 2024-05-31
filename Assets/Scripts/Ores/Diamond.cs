using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamond : Ore
{
    void OnEnable()
    {
        numberOfClick = 50;
        oreValue = 3000;
        GameManager.gm.ClickText.text = numberOfClick.ToString();
        GameManager.gm.ore = gameObject;
    }
}
