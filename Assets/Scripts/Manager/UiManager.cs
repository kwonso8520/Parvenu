using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    public void SetMoneyText()
    {
        GameManager.gm.moneyText.text = "Money : " + GameManager.gm.money; 
    }
}
