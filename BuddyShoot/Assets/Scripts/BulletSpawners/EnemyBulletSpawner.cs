using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletSpawner : BulletSpawner
{
    private void Start()
    {
        //Pattern();
        parentTransform = transform.parent;
        StartCoroutine(atkPattern());
    }
    
    public void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, parentTransform.position + new Vector3(0,-2,0), Quaternion.identity);
        bullet.layer = LayerMask.NameToLayer("Enemy_Bullet");
        bullet.GetComponent<Rigidbody>().velocity = -1 * bullet.transform.up * bulletSpeed;
        Debug.Log("bad");
        Destroy(bullet, 3f);
    }

    // public void Pattern()
    // {
    //     int nextShootTime = 1;
    //     Shoot();
    //     Invoke("Pattern",nextShootTime);
    // }

    IEnumerator atkPattern()
    {
        while(true)
        {
            Shoot();
            yield return new WaitForSeconds(1.2f);
        }
    }
}
