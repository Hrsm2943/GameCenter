using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusCoin : MonoBehaviour
{
    public string TagName;
    [SerializeField] private GameObject coin;
    [SerializeField] private CoinCasher CC;
    public int bonus;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == TagName)
        {
            Destroy(collision.gameObject);
            CC.CoinCash += bonus;
            CoinAppearance();
        }
    }

    void CoinAppearance()
    {
        GameObject instance = (GameObject)Instantiate(coin,
                                                      new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y - 0.1f, this.gameObject.transform.position.z),
                                                      Quaternion.identity);
    }
}
