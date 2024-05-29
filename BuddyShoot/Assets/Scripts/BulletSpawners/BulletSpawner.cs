using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float bulletSpeed;
    public Transform parentTransform;
    // Update is called once per frame
    

    public virtual void Shoot()
    {   
        parentTransform = transform.parent;
        GameObject bullet = Instantiate(bulletPrefab, parentTransform.position, Quaternion.identity);
        bullet.layer = LayerMask.NameToLayer("Player_Bullet");
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.up * bulletSpeed;
        Debug.Log(bullet.layer);
        Destroy(bullet, 3f);
    }
}
