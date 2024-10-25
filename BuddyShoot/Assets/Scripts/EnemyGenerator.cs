using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    Transform buddy;

    private void Awake()
    {
        buddy = transform.Find("Buddy");
    }
}
