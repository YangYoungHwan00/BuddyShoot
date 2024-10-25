using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class Yuta : Buddy
{
    public string ObjectID = "001";
    public int maxHelth;
    public int curHelth;
    public int atk;
    public int def;
    Transform parent;
    BuddyController player;
    
    void Start()
    {
        parent = transform.parent;
        player = parent.GetComponent<BuddyController>();
        maxHelth = player.maxHelth;
        curHelth = player.curHelth;
        atk = player.atk;
        def = player.def;
    }

    void Update()
    {
        
        if(Input.GetAxis("Horizontal")>0)
            spRenderer.flipX = true;
        if(Input.GetAxis("Horizontal")<0)
            spRenderer.flipX = false;
        player.curHelth = curHelth;
    }

    public override int TakeDamage(int hp, int atk, int def)
    {
        hp -= Convert.ToInt32((float)player.atk/(float)player.def);
        return hp;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(!other.gameObject.CompareTag("BuddyBullet"))
        {
            curHelth = TakeDamage(curHelth, atk, def);
        }
    }
}

