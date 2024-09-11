using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletSpawner : BulletSpawner
{
    private void Start()
    {
        Pattern();
    }
    
    public override void Shoot()
    {
        parentTransform = transform.parent;
        GameObject bullet = Instantiate(bulletPrefab, parentTransform.position + new Vector3(0,-2,0), Quaternion.identity);
        bullet.layer = LayerMask.NameToLayer("Enemy_Bullet");
        bullet.GetComponent<Rigidbody>().velocity = -1 * bullet.transform.up * bulletSpeed;
        Debug.Log("bad");
        Destroy(bullet, 3f);
    }

    public void Pattern()
    {
        int nextShootTime = 1;
        Shoot();
        Invoke("Pattern",nextShootTime);
    }
}
