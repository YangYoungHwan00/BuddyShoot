using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float destroyTime = 0f;

    private void OnCollisionEnter(Collision other) {
        Destroy(gameObject,destroyTime);
        Debug.Log("boom");
    }
}
