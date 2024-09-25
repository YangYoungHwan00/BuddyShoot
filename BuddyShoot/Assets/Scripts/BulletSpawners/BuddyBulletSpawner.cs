using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuddyBulletSpawner : BulletSpawner
{
    private void Start()
    {
        parentTransform = transform.parent;
        StartCoroutine(Shoot());
    }

    public IEnumerator Shoot()
    {
        while(true) 
        {
            GameObject bullet = Instantiate(bulletPrefab, parentTransform.position, Quaternion.identity);
            bullet.layer = LayerMask.NameToLayer("Player_Bullet");
            bullet.GetComponent<Rigidbody>().velocity = bullet.transform.up * bulletSpeed;
            Debug.Log("good");
            Destroy(bullet, 3f);
            yield return new WaitForSeconds(1.5f);
        }      
    }

    // public void Shoot()
    // {
    //     GameObject bullet = Instantiate(bulletPrefab, parentTransform.position + new Vector3(0,-2,0), Quaternion.identity);
    //     bullet.layer = LayerMask.NameToLayer("Enemy_Bullet");
    //     bullet.GetComponent<Rigidbody>().velocity = bullet.transform.up * bulletSpeed;
    //     Debug.Log("bad");
    //     Destroy(bullet, 3f);
    // }

    // void Pattern()
    // {
    //     float nextShootTime = 1.3f;
    //     Shoot();
    //     Invoke("Pattern",nextShootTime);
    // }
}
