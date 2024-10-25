using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buddy : MonoBehaviour
{
    public float Atk {get; set;}
    public float Def {get; set;}
    public float MoveSpeed {get; set;}
    public SpriteRenderer spRenderer;

    public Buddy()
    {
        Atk = 0;
        Def = 0;
        MoveSpeed = 0;
    }

    public Buddy(float atk, float def, float moveSpeed)
    {
        Atk = atk;
        Def = def;
        MoveSpeed = moveSpeed;
    }

    public virtual int TakeDamage(int hp, int atk, int def)
    {
        hp -= Convert.ToInt32(atk/def)*20;
        return hp;
    }
    
}
