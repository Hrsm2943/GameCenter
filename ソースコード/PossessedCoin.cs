using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PossessedCoin : MonoBehaviour
{
    public int P_Coin = 100;
    public int P_Coin_B = 0;
    public int F_to_Plus = 0;
    private int PrivateCnt = 0;
    public static PossessedCoin Inst;

    void Awake()
    {
        if (Inst == null)
        {
            Inst = this;
        }
    }

    void Update()
    {
        if(P_Coin_B > 0 && PrivateCnt == F_to_Plus)
        {
            P_Coin += 1;
            P_Coin_B -= 1;
            PrivateCnt = 0;
        }
        if(P_Coin_B == 0)
        {
            PrivateCnt = 0;
        }
        if(F_to_Plus > PrivateCnt)
        {
            PrivateCnt++;
        }
    }
}
