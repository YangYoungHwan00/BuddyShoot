using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class apple : Player
{
    public string ObjectID = "001";
    private string maxHelthKey = "MaxHelth";
    private string curHelthKey = "CurrentHelth";
    private string atkKey = "AttakPoint";
    private string defKey = "DeffensePoint";
    public int maxHelth;
    public int curHelth;
    public int atk;
    public int def;
    StatusManager status;
    int[] stat;

    void Start()
    {
        stat = new int[4];
        status.InitializeStatus(ObjectID);
        stat = status.loadStatus(ObjectID);
    }

    void Update()
    {
        Debug.Log(stat[0]);
       
    }

    void Damaged(Bullet b)
    {
        status.curHelth -= b.atk-def;
        status.saveStatus(ObjectID);
        Debug.Log("으악");
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

    private void OnCollisionEnter(Collision other) {
        Bullet b = other.gameObject.GetComponent<Bullet>();
        if(other.gameObject.CompareTag("Enemy_Bullet"))
            Damaged(b);
    }

}
