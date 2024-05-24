using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuddyController : MonoBehaviour
{
    public float speed = 10f;
    public string name = "maru";
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {   
        if(Input.GetKeyDown(KeyCode.Space))
        {
            CharacterTag();
        }
        
    }

    void FixedUpdate() 
    {
        if(Input.GetKey(KeyCode.UpArrow))
            transform.Translate(0,speed*Time.deltaTime,0);
        if(Input.GetKey(KeyCode.DownArrow))
            transform.Translate(0,-speed*Time.deltaTime,0);
        if(Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(-speed*Time.deltaTime,0,0);
        if(Input.GetKey(KeyCode.RightArrow))
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
}
