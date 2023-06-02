using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "S_Entity", menuName = "Create S_Entity")]

public class Shot_E_Entity : ScriptableObject
{
    public int EnemyID;
    public Sprite icon;
    public int Point;
}
