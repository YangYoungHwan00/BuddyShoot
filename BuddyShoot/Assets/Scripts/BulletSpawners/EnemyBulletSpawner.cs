using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletSpawner : BulletSpawner
{
    private void Start()
    {
        //Pattern();
        parentTransform = transform.parent;
        StartCoroutine(atkPattern(2f));
    }
    
    public void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, parentTransform.position+new Vector3(0,0,-1), Quaternion.identity);
        bullet.layer = LayerMask.NameToLayer("Enemy_Bullet");
        bullet.GetComponent<Rigidbody2D>().velocity = -1 * bullet.transform.up * bulletSpeed;
        Destroy(bullet, 3f);
    }

    IEnumerator atkPattern(float interval)
    {
        while(true)
        {
            Shoot();
            yield return new WaitForSeconds(interval);
        }
    }
}
