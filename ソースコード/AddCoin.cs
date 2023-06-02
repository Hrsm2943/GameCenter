using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddCoin : MonoBehaviour
{
    private int GCoin = 0;
    [SerializeField] private Text Tx;
    public float DestTime = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        GCoin = GameManeger.Inst.GetC_Num;
        Tx.text = "+" + GCoin.ToString();
        GameManeger.Inst.GetC_Num = 0;
        Invoke(nameof(Dest), DestTime);
    }

    void Dest()
    {
        PossessedCoin.Inst.P_Coin_B += GCoin;
        Destroy(this.gameObject);
    }
}
