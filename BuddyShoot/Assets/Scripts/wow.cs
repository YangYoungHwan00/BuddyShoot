using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    void Awake()
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
        player.curHelth = curHelth;
    }

    public override int Damaged(int hp, int atk ,int def)
    {
        hp -= atk;
        Debug.Log(hp);
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

    private void OnCollisionEnter(Collision other) {
        curHelth = Damaged(curHelth,atk,def);
    }
}
