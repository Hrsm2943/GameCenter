using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public float DestTime;
    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(DestroyObj), DestTime);
    }

    void DestroyObj()
    {
        Destroy(this.gameObject);
    }
}
