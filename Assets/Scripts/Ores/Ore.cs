using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ore : MonoBehaviour
{
    [HideInInspector]
    public int numberOfClick;
    [HideInInspector]
    public int oreValue;

    void Update()
    {
        DestroyOre();
    }
    private void OnMouseDown()
    {
        numberOfClick --;
        GameManager.gm.ClickText.text = numberOfClick.ToString();
        Debug.Log("남은 클릭횟수" + numberOfClick);
    }
    public void DestroyOre()
    {
        if (numberOfClick <= 0)
        {
            GameManager.gm.moneyManager.GetMoney();
            GameManager.gm.uiManager.SetMoneyText();
            GameManager.gm.ore = null;
            gameObject.SetActive(false);
        }
    }
}
