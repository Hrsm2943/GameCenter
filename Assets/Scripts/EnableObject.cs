using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableObject : MonoBehaviour
{
    [SerializeField] GameManeger GM;
    [SerializeField] List<GameObject> GOList;
    [SerializeField] GameObject EnableText;
    [SerializeField] GameObject LeaveText;
    [SerializeField] GameObject PlayText;
    [SerializeField] GameObject M_Cam;
    [SerializeField] GameObject S_Cam;

    void FixedUpdate()
    {
        if (GM.GetKeyCode(KeyCode.Escape) == true && GM.GameStart == true)
        {
            EnableText.SetActive(true);
            GM.GameStart = false;
            GM.PM.Move_Enable = true;
            LeaveText.SetActive(false);
            PlayText.SetActive(false);
            M_Cam.SetActive(true);
            S_Cam.SetActive(false);
        }

    }

    void OnTriggerEnter(Collider other)
    {
        //接触したオブジェクトのタグが"Player"のとき
        if (other.CompareTag("Player"))
        {
            this.gameObject.GetComponent<DisableObject>().enabled = true;
            for (int i = 0; i < GOList.Count; i++)
            {
                GOList[i].SetActive(true);
            }
        }

        
    }

    void OnTriggerExit(Collider other)
    {
        //離れたオブジェクトのタグが"Player"のとき
        if (other.CompareTag("Player"))
        {
            this.gameObject.GetComponent<DisableObject>().enabled = false;
            for (int i = 0; i < GOList.Count; i++)
            {
                GOList[i].SetActive(false);
            }
        }
    }


}
