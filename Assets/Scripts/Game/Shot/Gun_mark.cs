using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gun_mark : MonoBehaviour
{
    [SerializeField] Image img;
    [SerializeField] BoxCollider2D col;
    float alpha = 1.0f;
    public float DelSpeed = 0.001f;
    private bool IsCol = true;
    private int cnt = 0;
    public int HitCnt = 0;

    float r, g, b, a;

    void Start()
    {
        r = img.color.r;
        g = img.color.g;
        b = img.color.b;
        a = img.color.a;
    }

    void Update()
    {
        if(alpha <= 0)
        {
            Destroy(this.gameObject);
        }
        if(IsCol && cnt == HitCnt)
        {
            col.enabled = !col.enabled;
            IsCol = false;
        }
        img.color = new Color(r, g, b, alpha); ;
        alpha -= DelSpeed;
        cnt++;
        
    }
}
