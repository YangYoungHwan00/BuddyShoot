using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int atk = 50;

    private void OnCollisionEnter(Collision other) {
        Destroy(gameObject,3f);
        Debug.Log("boom");
    }
}
