using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCasher : MonoBehaviour
{
    [SerializeField] private GameObject coin;
    private float Sec = 1;
    [SerializeField, Range(0.0001f, 0.01f)] private float SecCount;
    public int CoinCash = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Sec >= 1 && CoinCash > 0)
        {
            GameObject instance = (GameObject)Instantiate(coin,
                                                      new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z),
                                                      Quaternion.identity);
            CoinCash -= 1;
            Sec = 0;
        }
        else
        {
            Sec += SecCount;
        }
    }
}
