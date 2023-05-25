using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManeger : MonoBehaviour
{
    [SerializeField]public Player_Move PM;
    [SerializeField] public string SN;
    public bool GameStart = false;
    public int GetC_Num = 0;
    [SerializeField] public GameObject AddCoins;
    [SerializeField] public Transform P_AddCoins;

    public static GameManeger Inst;

    void Awake()
    {
        if(Inst == null)
        {
            Inst = this;
        }
    }

    public bool GetKeyCode(KeyCode keycode)
    {
        return Input.GetKey(keycode);
    }

    public void CopyTransform(GameObject OriginObj, GameObject CopyObj)
    {
        CopyObj.transform.position = OriginObj.transform.position;
        CopyObj.transform.rotation = OriginObj.transform.rotation;
    }

    public void Set_AddCoin(int GCoin)
    {
        GetC_Num = GCoin;
        GameObject instance = (GameObject)Instantiate(AddCoins,
                                                      new Vector3(769.0181f, 321.7877f, 0.0f),
                                                      Quaternion.identity);
        instance.transform.SetParent(P_AddCoins, false);
    }
}
