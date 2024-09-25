using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class wow : Player
{
    public string ObjectID = "002";
    public int maxHelth;
    public int curHelth;
    public int atk;
    public int def;
    StatusManager status;
    Transform parent;
    BuddyController player;

    // Start is called before the first frame update
    void Start()
    {
        parent = transform.parent;
        player = parent.GetComponent<BuddyController>();
        maxHelth = player.maxHelth;
        curHelth = player.curHelth;
        atk = player.atk;
        def = player.def;
    }

    // Update is called once per frame
    void Update()
    {
        curHelth = player.curHelth;
    }

    public override int Damaged(int hp, int atk, int def)
    {
        hp -= Convert.ToInt32((float)player.atk/(float)player.def);
        Debug.Log(player.curHelth);
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
    }

    private void OnTriggerEnter(Collider other) {
        if(!other.gameObject.CompareTag("PlayerBullet"))
            curHelth = Damaged(curHelth, atk, def);
        Debug.Log("Hit");
    }
}
