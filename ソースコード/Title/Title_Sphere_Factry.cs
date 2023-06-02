using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Title_Sphere_Factry : MonoBehaviour
{
    [SerializeField] private GameObject T_Sphere;
    private int cnt = 0;

    // Update is called once per frame
    void Update()
    {
        if(cnt == 240)
        {
            ObjAppearance();
            cnt = 0;
        }
        cnt++;
    }

    void ObjAppearance()
    {
        GameObject instance = (GameObject)Instantiate(T_Sphere,
                                                      new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z),
                                                      Quaternion.identity);
    }
}
