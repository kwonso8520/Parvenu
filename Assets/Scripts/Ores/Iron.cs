using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Iron : Ore
{
    void OnEnable()
    {
        numberOfClick = 20;
        oreValue = 500;
        GameManager.gm.ClickText.text = numberOfClick.ToString();
        GameManager.gm.ore = gameObject;
    }
}
