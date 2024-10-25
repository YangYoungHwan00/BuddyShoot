using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Enemy : MonoBehaviour
{
    public int maxHelth;
    public int curHelth;
    public int atk;
    public int def;
    GameObject player;
    public Rigidbody2D target;
    public Rigidbody2D rigid;
    public SpriteRenderer spRenderer;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if(curHelth<=0)
            Destroy(gameObject);
    }

    public void MoveToBuddy(float speed)
    {
        Vector2 dirVec = target.position - rigid.position;
        Vector2 nextVec = dirVec.normalized * speed * Time.fixedDeltaTime;
        if(dirVec.x>0)
            spRenderer.flipX = true;
        else if(dirVec.x<0)
            spRenderer.flipX = false;
        rigid.MovePosition(rigid.position + nextVec);
        rigid.velocity = Vector2.zero;
    }

    public virtual int TakeDamage(int hp, int atk, int def)
    {
        hp -= Convert.ToInt32(atk/def)*20;
        return hp;
    }
}
