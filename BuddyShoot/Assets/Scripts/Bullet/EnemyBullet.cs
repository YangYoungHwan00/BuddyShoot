using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : Bullet
{
    private void OnTriggerEnter(Collider other) {
        if(!(other.gameObject.CompareTag("Enemy")||other.gameObject.CompareTag("BuddyBullet")))
            Destroy(gameObject);
    }
}
