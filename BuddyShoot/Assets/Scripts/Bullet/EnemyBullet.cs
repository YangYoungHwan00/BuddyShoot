using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : Bullet
{
    private void OnCollisionEnter(Collision other) {
        if(!other.gameObject.CompareTag("Enemy"))
            Destroy(gameObject);
    }
}
