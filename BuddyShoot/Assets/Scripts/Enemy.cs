using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    GameObject player;
    public Rigidbody2D target;
    public Rigidbody2D rigid;
    public SpriteRenderer spRenderer;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    public void MoveToBuddy(float speed)
    {
        Vector2 dirVec = target.position - rigid.position;
        Vector2 nextVec = dirVec.normalized * speed * Time.fixedDeltaTime;
        rigid.MovePosition(rigid.position + nextVec);
        rigid.velocity = Vector2.zero;
    }
}
