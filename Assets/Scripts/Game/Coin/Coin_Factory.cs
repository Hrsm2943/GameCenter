using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Factory : MonoBehaviour
{
    [SerializeField] GameManeger GM;
    [SerializeField] PossessedCoin PC;
    [SerializeField, Range(0.0001f, 1f)] private float SecCount;
    [SerializeField, Range(1, 999)] private int ReduceCoin;
    private float Sec = 1;
    [SerializeField] private GameObject coin;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GM.GameStart == true && GM.GetKeyCode(KeyCode.Space) == true && Sec >= 1 && PC.P_Coin > 0)
        {
            CoinAppearance();
            PC.P_Coin -= ReduceCoin;
            Sec = 0;
        }
        else if (Sec < 1)
        {
            Sec += SecCount;
        }
    }

    public void CoinAppearance()
    {
        GameObject instance = (GameObject)Instantiate(coin,
                                                      new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z),
                                                      Quaternion.identity);
    }
}
