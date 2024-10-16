using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mob1 : Enemy
{
    void FixedUpdate()
    {
        MoveToBuddy(4f);
    }
}
