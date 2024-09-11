using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wow : Player
{
    public string ObjectID = "002";
    private string maxHelthKey = "MaxHelth";
    private string curHelthKey = "CurrentHelth";
    private string atkKey = "AttakPoint";
    private string defKey = "DeffensePoint";
    public int maxHelth;
    public int curHelth;
    public int atk;
    public int def;
    StatusManager status;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Damaged(Bullet b)
    {
        status.curHelth -= b.atk-def;
        status.saveStatus(ObjectID);
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
        Bullet b = other.gameObject.GetComponent<Bullet>();
        if(other.gameObject.CompareTag("Enemy_Bullet"))
            Damaged(b);
    }
}
