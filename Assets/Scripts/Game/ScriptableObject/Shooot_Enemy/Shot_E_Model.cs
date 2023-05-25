using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Shot_E_Model
{
    public int EnemyID;
    public Sprite icon;
    public int Point;

    public Shot_E_Model(int S_ID)
    {
        Shot_E_Entity S_Entity = Resources.Load<Shot_E_Entity>("Shot_Enti/S_Entity" + S_ID);

        EnemyID = S_Entity.EnemyID;
        icon = S_Entity.icon;
        Point = S_Entity.Point;
    }
}