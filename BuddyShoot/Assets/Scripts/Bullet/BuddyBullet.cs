using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuddyBullet : Bullet
{
    private void OnTriggerEnter2D(Collider2D other) {
        if(!(other.gameObject.CompareTag("Player")||other.gameObject.CompareTag("EnemyBullet")))
            Destroy(gameObject);
    }
}
