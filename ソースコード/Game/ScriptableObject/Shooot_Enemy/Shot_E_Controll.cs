using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot_E_Controll : MonoBehaviour
{
    public Shot_E_View view; // カードの見た目の処理
    public Shot_E_Model model; // カードのデータを処理
    public Shot_E_Coin SE_Coin;

    private void Awake()
    {
        view = GetComponent<Shot_E_View>();
    }

    public void Init(int S_ID) // カードを生成した時に呼ばれる関数
    {
        model = new Shot_E_Model(S_ID); // カードデータを生成
        view.Show(model); // 表示
        SE_Coin.GCoin = model.Point;
    }
}