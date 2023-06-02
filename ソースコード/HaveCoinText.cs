using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HaveCoinText : MonoBehaviour
{
    [SerializeField] private Text HaveCoin;
    [SerializeField] private PossessedCoin PCoin;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HaveCoin.text = PCoin.P_Coin.ToString();
    }
}
