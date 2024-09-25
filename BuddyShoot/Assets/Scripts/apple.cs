using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class apple : Player
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

    public override int Damaged(int hp, int atk, int def)
    {
        hp -= Convert.ToInt32((float)player.atk/(float)player.def);
        return hp;
    }

    void Dead()
    {
        GameObject wow = transform.Find("wow").gameObject;
        wow b = wow.GetComponent<wow>();
        if(b.curHelth>0)
        {
            BuddyController bu = transform.parent.GetComponent<BuddyController>();
            bu.CharacterTag();
        }
        Debug.Log("Die");
    }

    private void OnTriggerEnter(Collider other) {
        if(!other.gameObject.CompareTag("PlayerBullet"))
            curHelth = Damaged(curHelth, atk, def);
        Debug.Log("Hit!!!!!!");
    }

}
