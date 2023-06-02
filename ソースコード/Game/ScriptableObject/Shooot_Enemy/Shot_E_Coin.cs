using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Shot_E_Coin : MonoBehaviour
{
    public int GCoin = 0;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Gun_Mark"))
        {
            GameManeger.Inst.Set_AddCoin(GCoin);
            Destroy(this.gameObject);
        }
    }
}
