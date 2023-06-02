using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot_E_Controll : MonoBehaviour
{
    public Shot_E_View view; // �J�[�h�̌����ڂ̏���
    public Shot_E_Model model; // �J�[�h�̃f�[�^������
    public Shot_E_Coin SE_Coin;

    private void Awake()
    {
        view = GetComponent<Shot_E_View>();
    }

    public void Init(int S_ID) // �J�[�h�𐶐��������ɌĂ΂��֐�
    {
        model = new Shot_E_Model(S_ID); // �J�[�h�f�[�^�𐶐�
        view.Show(model); // �\��
        SE_Coin.GCoin = model.Point;
    }
}