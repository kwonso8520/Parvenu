using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : Ore
{
    void OnEnable()
    {
        numberOfClick = 30;
        oreValue = 1000;
        GameManager.gm.ClickText.text = numberOfClick.ToString();
        GameManager.gm.ore = gameObject;
    }
}
