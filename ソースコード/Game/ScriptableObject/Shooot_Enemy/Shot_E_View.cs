using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shot_E_View : MonoBehaviour
{
    [SerializeField] Text PointText;
    [SerializeField] Image iconImage;

    public void Show(Shot_E_Model S_E_Model) // S_E_Modelのデータ取得と反映
    {
        PointText.text = S_E_Model.Point.ToString();
        iconImage.sprite = S_E_Model.icon;
    }
}
