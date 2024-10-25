using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using System;


public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float bulletSpeed;
    public Transform parentTransform;

    static public Vector2 RotationMatrix2D(Vector2 vector,float seta)
    {
        Vector2 rotatedMatrix;
        rotatedMatrix = new ((float)(vector.x*Math.Cos(seta)-vector.y*Math.Sin(seta)),(float)(vector.x*Math.Sin(seta)+vector.y*Math.Cos(seta)));
        return rotatedMatrix;
    }
    
    // public virtual void Shoot()
    // {
    //     parentTransform = transform.parent;
    //     GameObject bullet = Instantiate(bulletPrefab, parentTransform.position, Quaternion.identity);
    //     bullet.layer = LayerMask.NameToLayer("Player_Bullet");
    //     bullet.GetComponent<Rigidbody>().velocity = bullet.transform.up * bulletSpeed;
    //     Debug.Log(bullet.layer);
    //     Destroy(bullet, 3f);
    // }
    
}
