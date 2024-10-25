using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BuddyBulletSpawner : BulletSpawner
{
    private Vector2 lastDir = Vector2.up;

    private void Awake()
    {
        parentTransform = transform.parent;
        bulletSpeed = 20f;
    }
    
    void FixedUpdate()
    {
        lastDir = transform.parent.parent.GetComponent<BuddyController>().lastDir;
        Debug.Log(1*1*Math.Cos(30));
    }

    public IEnumerator LongShot(float interval,int bulletLevel)
    {
        while(true) 
        {
            switch(bulletLevel)
            {
                case 0:
                    GameObject bullet = Instantiate(bulletPrefab, parentTransform.position+new Vector3(0,0,-1), Quaternion.identity);
                    bullet.layer = LayerMask.NameToLayer("Buddy_Bullet");
                    bullet.GetComponent<Rigidbody2D>().velocity = lastDir * bulletSpeed;
                    Destroy(bullet, 3f);
                    yield return new WaitForSeconds(interval);
                    break;
                
                case 1:
                    bullet = Instantiate(bulletPrefab, parentTransform.position+new Vector3(0,0,-1), Quaternion.identity);
                    GameObject bullet2 = Instantiate(bulletPrefab, parentTransform.position+new Vector3(0,0,-1), Quaternion.identity);
                    bullet.layer = LayerMask.NameToLayer("Buddy_Bullet");
                    bullet2.layer = LayerMask.NameToLayer("Buddy_Bullet");
                    bullet.GetComponent<Rigidbody2D>().velocity =  bulletSpeed *new Vector2(-1,10)/10;
                    bullet2.GetComponent<Rigidbody2D>().velocity =  bulletSpeed * new Vector2(1,10)/10;
                    Destroy(bullet, 3f);
                    yield return new WaitForSeconds(interval);
                    break;
                
                case 2:
                    bullet = Instantiate(bulletPrefab, parentTransform.position+new Vector3(0,0,-1), Quaternion.identity);
                    bullet2 = Instantiate(bulletPrefab, parentTransform.position+new Vector3(0,0,-1), Quaternion.identity);
                    GameObject bullet3 = Instantiate(bulletPrefab, parentTransform.position+new Vector3(0,0,-1), Quaternion.identity);
                    bullet.layer = LayerMask.NameToLayer("Buddy_Bullet");
                    bullet2.layer = LayerMask.NameToLayer("Buddy_Bullet");
                    bullet3.layer = LayerMask.NameToLayer("Buddy_Bullet");
                    bullet.GetComponent<Rigidbody2D>().velocity = bulletSpeed * RotationMatrix2D(lastDir,(float)Math.PI/6).normalized;
                    bullet2.GetComponent<Rigidbody2D>().velocity = bulletSpeed * lastDir.normalized;
                    bullet3.GetComponent<Rigidbody2D>().velocity = bulletSpeed * RotationMatrix2D(lastDir,-(float)Math.PI/6).normalized;
                    Destroy(bullet, 3f);
                    yield return new WaitForSeconds(interval);
                    break;
                    
            }
        }      
    }

    public IEnumerator CloseShot(float interval)
    {
        while(true)
        {
            GameObject bullet = Instantiate(bulletPrefab, parentTransform.position+new Vector3(lastDir.x,lastDir.y,0).normalized *5f, Quaternion.identity);
            bullet.layer = LayerMask.NameToLayer("Buddy_Bullet");
            // bullet.GetComponent<Rigidbody2D>().velocity = parentTransform.up * bulletSpeed;
            Destroy(bullet, 1f);
            yield return new WaitForSeconds(interval);
        }
    }
}
