using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour
{
    [SerializeField] GameObject Gun_mark;
    private GameObject obj;
    [SerializeField] GameObject ParentObj;
    private Vector3 mouse;

    void Update()
    {
        if (Input.mousePosition.x - 960 <= 460 && Input.mousePosition.x - 960 >= -460)
        {
            mouse.x = Input.mousePosition.x - 960;
        }
        if (Input.mousePosition.y - 540 <= 460 && Input.mousePosition.y - 540 >= -460)
        {
            mouse.y = Input.mousePosition.y - 540;
        }
        this.transform.localPosition = mouse;
        if(Input.GetMouseButtonDown(0))
        {
            obj = (GameObject)Instantiate(Gun_mark, mouse, Quaternion.identity);
            obj.transform.SetParent(ParentObj.transform, false);
        }
    }
}
