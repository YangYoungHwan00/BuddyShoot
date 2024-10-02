using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Stat
{
    public float Hp;
    public float Atk;
    public float Def;

    public Stat()
    {
        Hp = 1;
        Atk =1;
        Def = 1;
    }

    public Stat(float hp, float atk, float def)
    {        
        Hp = hp;
        Atk = atk;
        Def = def;        
    }
}

