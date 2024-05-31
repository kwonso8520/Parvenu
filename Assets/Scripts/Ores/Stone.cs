using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : Ore
{
    // Start is called before the first frame update
    void OnEnable()
    {
        numberOfClick = 10;
        oreValue = 300;
        GameManager.gm.ClickText.text = numberOfClick.ToString();
        GameManager.gm.ore = gameObject;
    }
}
