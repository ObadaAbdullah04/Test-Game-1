using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class coincounter : MonoBehaviour
{
    public static coincounter instance;
    public TMP_Text cointext;
    public int currentcoins =0;
    void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        cointext.text = "x" + currentcoins.ToString();
    }

    public void Increasecoins(int v)
    {
        currentcoins +=v;
        cointext.text = "x" +currentcoins.ToString();
    }
}
