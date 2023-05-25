using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private GameObject coin;

    void Start()
    {
        CoinAppearance();
    }

    public void CoinAppearance()
    {
        GameObject instance = (GameObject)Instantiate(coin,
                                                      new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z),
                                                      Quaternion.identity);
    }
}