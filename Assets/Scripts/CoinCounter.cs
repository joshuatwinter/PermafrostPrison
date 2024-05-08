using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    public static CoinCounter instance;

    public TMP_Text coinText;
    public int currentCoins = 0;

    void Awake()
    {
        instance = this;
    }


    void Start()
    {
        coinText.text = "GOLD: " + currentCoins.ToString();

    }

    public void IncreaseCoins(int v)
    {
        currentCoins += v;
        coinText.text = "GOLD: " + currentCoins.ToString();

    }

}







