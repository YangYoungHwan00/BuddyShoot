using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int atk = 10;

    private void OnCollisionEnter(Collision other) {
        Destroy(gameObject,0.03f);
        Debug.Log("boom");
    }
}
