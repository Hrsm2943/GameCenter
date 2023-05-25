using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Set_Shooot_State : MonoBehaviour
{
    [SerializeField] GameObject ParentObj;
    [SerializeField] Shot_E_Controll S_EPrefab;
    GameObject[] tagobjs;

    private int ResetSec = 0;
    //0:特になし 1:オブジェクトを縦に縮小 2:オブジェクトを削除　3:オブジェクトを縦に拡張
    private int ResetState = 0;
    public int ResetTime = 1000;
    private float ShriNum = 1;
    private Vector3 loc;

    // Start is called before the first frame update
    void Start()
    {
        SetEnemy();
    }

    // Update is called once per frame
    void Update()
    {

        
        switch(ResetState)
        {
            case 0:
                if (ResetSec >= ResetTime)
                {
                    ObjShrink();
                }
                else
                {
                    ResetSec++;
                }
                break;
            case 1:
                ResetEnemy();
                break;
            case 2:
                ObjExpan();
                break;
            case 3:
                SetEnemy();
                ResetSec = 0;
                ResetState = 0;
                break;

        }
    }

    void ObjShrink()
    {
        tagobjs = GameObject.FindGameObjectsWithTag("Shot_E");
        foreach (GameObject obj in tagobjs)
        {
            obj.transform.localScale = new Vector3(1, ShriNum, 1);
        }
        ShriNum -= 0.005f;
        if(ShriNum <= 0)
        {
            ResetState = 1;
        }
    }

    void ObjExpan()
    {
        ResetState = 3;
    }

    void ResetEnemy()
    {
        tagobjs = GameObject.FindGameObjectsWithTag("Shot_E");
        foreach (GameObject obj in tagobjs)
        {
            Destroy(obj);
        }
        ShriNum = 1;
        ResetState = 2;
    }

    void SetEnemy()
    {
        Random.InitState(System.DateTime.Now.Millisecond);
        for (int i = 0; i < 6; i++)
        {
            int num = Random.Range(1, 4);
            DispShotEnemy(num);
        }
        tagobjs = GameObject.FindGameObjectsWithTag("Shot_E");
        foreach (GameObject obj in tagobjs)
        {
            obj.transform.SetParent(ParentObj.transform, false);
        }
    }

    void DispShotEnemy(int ID)
    {
        Shot_E_Controll S_E_Cont;
        switch (ID)
        {
            case 1:
                loc.x = Random.Range(-412, 412);
                loc.y = Random.Range(-412, 412);
                break;
            case 2:
                loc.x = Random.Range(-412, 412);
                loc.y = Random.Range(-412, 90);
                break;
            case 3:
                loc.x = Random.Range(-412, 412);
                loc.y = Random.Range(0, 412);
                break;
        }
        S_E_Cont = (Shot_E_Controll)Instantiate(S_EPrefab, loc, Quaternion.identity);
        S_E_Cont.Init(ID);
    }

    Vector3 SetPlace_position(int num)
    {
        int x_posi = 0;
        int y_posi = 0;
        switch (num)
        {
            case 1:
                x_posi = Random.Range(-412, 412);
                y_posi = Random.Range(-412, 412);
                break;
            case 2:
                x_posi = Random.Range(-412, 412);
                y_posi = Random.Range(-412, 90);
                break;
            case 3:
                x_posi = Random.Range(-412, 412);
                y_posi = Random.Range(0, 412);
                break;
        }

        Vector3 Ret = new Vector3(x_posi, y_posi, 0);

        return Ret;
    }
}
