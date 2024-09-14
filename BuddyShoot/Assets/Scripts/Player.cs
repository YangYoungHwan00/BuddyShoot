using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual int Damaged(int hp, int atk, int def)
    {
        hp -= Convert.ToInt32(atk/def)*20;
        return hp;
    }
}
