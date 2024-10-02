using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class Maru : Buddy
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
        //Debug.Log(stat[0]);
        player.curHelth = curHelth;
    }

    public override int TakeDamage(int hp, int atk, int def)
    {
        hp -= Convert.ToInt32((float)player.atk/(float)player.def);
        return hp;
    }

    private void OnTriggerEnter(Collider other) {
        if(!other.gameObject.CompareTag("BuddyBullet"))
            curHelth = TakeDamage(curHelth, atk, def);
    }

}
