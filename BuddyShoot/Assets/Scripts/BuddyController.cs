using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuddyController : MonoBehaviour
{
    public float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {   
        if(Input.GetKeyDown(KeyCode.Space))
            CharacterTag();

        if(Input.GetKeyDown(KeyCode.K))
            Shoot();
        
    }

    void FixedUpdate() 
    {
        if(Input.GetKey(KeyCode.W))
            transform.Translate(0,speed*Time.deltaTime,0);
        if(Input.GetKey(KeyCode.S))
            transform.Translate(0,-speed*Time.deltaTime,0);
        if(Input.GetKey(KeyCode.A))
            transform.Translate(-speed*Time.deltaTime,0,0);
        if(Input.GetKey(KeyCode.D))
            transform.Translate(speed*Time.deltaTime,0,0);
    }

    void CharacterTag()
    {
        GameObject a = transform.GetChild(0).gameObject;
        GameObject b = transform.GetChild(1).gameObject;
        
        if(a.activeSelf)
        {
            a.SetActive(false);
            b.SetActive(true);
            Debug.Log("good");
        }
        else
        {
            a.SetActive(true);
            b.SetActive(false);
            Debug.Log("bad");
        }
    }

    void Shoot()
    {
        Debug.Log("fire");
        
    }
}
