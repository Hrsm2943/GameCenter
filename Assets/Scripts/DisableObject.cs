using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableObject : MonoBehaviour
{
    [SerializeField] GameManeger GM;
    [SerializeField] GameObject EnableText;
    [SerializeField] GameObject LeaveText;
    [SerializeField] GameObject PlayText;
    [SerializeField] GameObject M_Cam;
    [SerializeField] GameObject S_Cam;
    [SerializeField] GameObject DispLocate;

    // Update is called once per frame
    void FixedUpdate()
    {
        if(GM.GetKeyCode(KeyCode.E) == true)
        {
            EnableText.SetActive(false);
            LeaveText.SetActive(true);
            PlayText.SetActive(true);
            GM.GameStart = true;
            GM.PM.Move_Enable = false;
            GM.CopyTransform(DispLocate, S_Cam);
            M_Cam.SetActive(false);
            S_Cam.SetActive(true);
        }

    }
}
