using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager gm;
    [HideInInspector]
    public int money = 0;
    [HideInInspector]
    public GameObject ore;
    public Text moneyText;
    public Text ClickText;
    public MoneyManager moneyManager;
    public UiManager uiManager;
    public GameObject[] oreObjs;
    // Start is called before the first frame update
    private void Awake()
    {
        if(gm == null)
        {
            gm = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        CreateNewOre();
    }
    void CreateNewOre()
    {
        if (ore == null)
        {
            int rand = Random.Range(0, 7);
            switch (rand)
            {
                case 0:
                    oreObjs[0].SetActive(true);
                    break;
                case 1:
                    oreObjs[1].SetActive(true);
                    break;
                case 2:
                    oreObjs[2].SetActive(true);
                    break;
                case 3:
                    oreObjs[3].SetActive(true);
                    break;
                case 4:
                    oreObjs[4].SetActive(true);
                    break;
                case 5:
                    oreObjs[5].SetActive(true);
                    break;
                case 6:
                    oreObjs[6].SetActive(true);
                    break;
            }
        }
    }
}
