using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayTime : MonoBehaviour
{
    public float ProgressSpeed = 1.0f;

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(transform.position, Vector3.right, ProgressSpeed);
    }
}
