using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletSpawner : BulletSpawner
{
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.K))
        {
            Shoot();
        }
    }
    
    public override void Shoot()
    {
        parentTransform = transform.parent;
        GameObject bullet = Instantiate(bulletPrefab, parentTransform.position, Quaternion.identity);
        bullet.layer = LayerMask.NameToLayer("Player_Bullet");
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.up * bulletSpeed;
        Debug.Log("good");
        Destroy(bullet, 3f);
    }
}
