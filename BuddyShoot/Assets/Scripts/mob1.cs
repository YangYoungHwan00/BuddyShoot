using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mob1 : Enemy
{
    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        atk = 10;
        def = 10;
        maxHelth = 100;
        curHelth = maxHelth;
    }

    
    void FixedUpdate()
    {
        MoveToBuddy(4f);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("BuddyBullet"))
        {
            curHelth = TakeDamage(curHelth, atk, def);   
        }
            
        
    }
}
