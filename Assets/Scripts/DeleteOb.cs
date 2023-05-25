using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteOb : MonoBehaviour
{
	public string TagName;
	public bool IfGet = false;
	public int GetCoin = 0;

	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == TagName)
		{
			if(IfGet)
            {
				GameManeger.Inst.Set_AddCoin(GetCoin);
			}
			Destroy(collision.gameObject);
		}
	}
}
