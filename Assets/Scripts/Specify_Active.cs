using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Specify_Active : MonoBehaviour
{
    [SerializeField] private GameObject obj;
    [SerializeField] private GameObject FALobj;
    [SerializeField] private Player_Move PM;

    public void OnClick()
    {
        obj.SetActive(true);
    }

    public void IsFALSE()
    {
        FALobj.SetActive(false);
    }

    public void notMove()
    {
        PM.Move_Enable = false;
    }

    public void IsMove()
    {
        PM.Move_Enable = true;
    }


}
