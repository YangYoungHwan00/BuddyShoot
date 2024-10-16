using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuddyBulletSpawner : BulletSpawner
{
    private void Start()
    {
        parentTransform = transform.parent;
        StartCoroutine(Shoot(1f));
    }

    public IEnumerator Shoot(float interval)
    {
        while(true) 
        {
            GameObject bullet = Instantiate(bulletPrefab, parentTransform.position+new Vector3(0,0,-1), Quaternion.identity);
            bullet.layer = LayerMask.NameToLayer("Buddy_Bullet");
            bullet.GetComponent<Rigidbody2D>().velocity = parentTransform.up * bulletSpeed;
            Destroy(bullet, 3f);
            yield return new WaitForSeconds(interval);
        }      
    }
}
