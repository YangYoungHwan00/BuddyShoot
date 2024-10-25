using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float destroyTime = 0f;
    int atk;

    private void OnCollisionEnter2D(Collision2D other) {
        Destroy(gameObject,destroyTime);
        Debug.Log("boom");
    }
}
