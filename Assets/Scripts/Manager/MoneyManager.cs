using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void GetMoney()
    {
        GameManager.gm.money += GameManager.gm.ore.GetComponent<Ore>().oreValue;
    }
}
