using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mob1 : Enemy
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Buddy");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
