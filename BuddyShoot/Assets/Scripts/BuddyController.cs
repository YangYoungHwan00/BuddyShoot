using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuddyController : MonoBehaviour
{
    public float speed = 10f;
    private GameObject[] buddy;
    public int maxHelth = 100;
    public int curHelth;
    public int atk = 100;
    public int def = 100;
    public GameObject gameover;

    // Start is called before the first frame update
    void Awake()
    {
        buddy = new GameObject[transform.childCount];
        buddy[0] = transform.Find("apple").gameObject;
        buddy[1] = transform.Find("wow").gameObject;  
        curHelth = maxHelth;
    }

    // Update is called once per frame
    void Update()
    { 
        if(Input.GetKeyDown(KeyCode.Space))
        {
            CharacterTag();
        }
        
        if(curHelth <= 0)
            Dead();

        Debug.Log(gameover);
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

    public void CharacterTag()
    {
        // GameObject a = transform.Find("apple").gameObject;
        // GameObject b = transform.Find("wow").gameObject;
        
        if(buddy[0].activeSelf)
        {
            buddy[0].SetActive(false);
            buddy[1].SetActive(true);
            Debug.Log("good");
        }

        else
        {
            buddy[0].SetActive(true);
            buddy[1].SetActive(false);
            Debug.Log("bad");
        }
    }

    void Dead()
    {
        gameover.SetActive(true);
    }
}
