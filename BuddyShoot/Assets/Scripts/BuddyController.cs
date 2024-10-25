using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuddyController : MonoBehaviour
{
    public float speed = 10f;
    private GameObject[] buddy;
    private GameObject[] buddyBulletSpawner;
    public int maxHelth = 100;
    public int curHelth;
    public int atk = 100;
    public int def = 100;
    public GameObject gameover;
    private GameObject buddyUI;
    private bool canShoot = true;
    public Vector2 lastDir = Vector2.up;

    // Start is called before the first frame update
    void Awake()
    {
        buddy = new GameObject[transform.childCount];
        buddy[0] = transform.Find("Yuta").gameObject;
        buddy[1] = transform.Find("Maru").gameObject;
        buddyBulletSpawner = new GameObject[transform.childCount];
        buddyBulletSpawner[0] = buddy[0].transform.Find("Bullet Spawner").gameObject;
        buddyBulletSpawner[1] = buddy[1].transform.Find("Bullet Spawner2").gameObject;
        buddyUI = GameObject.Find("buddyUI");
        curHelth = maxHelth;
        buddyBulletSpawner[0].GetComponent<BuddyBulletSpawner>().StartCoroutine(
                buddyBulletSpawner[0].GetComponent<BuddyBulletSpawner>().CloseShot(1f));
    }

    // Update is called once per frame
    void Update()
    { 
        if(Input.GetKeyDown(KeyCode.Space)&&canShoot)
        {
            CharacterTag();
        }
        
        if(curHelth <= 0)
            Dead();
    }

    void FixedUpdate() 
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        Vector2 moveDir = new Vector2(moveX,moveY);
        if(moveX!=0||moveY!=0)
            lastDir = moveDir;

        if(moveDir != Vector2.zero)
        {
            transform.Translate(moveDir*speed*Time.deltaTime);
        }
        // if(Input.GetKey(KeyCode.W))
        //     transform.Translate(0,speed*Time.deltaTime,0);
        // if(Input.GetKey(KeyCode.S))
        //     transform.Translate(0,-speed*Time.deltaTime,0);
        // if(Input.GetKey(KeyCode.A))
        //     transform.Translate(-speed*Time.deltaTime,0,0);
        // if(Input.GetKey(KeyCode.D))
        //     transform.Translate(speed*Time.deltaTime,0,0);
    }

    public void CharacterTag()
    {
        // GameObject a = transform.Find("apple").gameObject;
        // GameObject b = transform.Find("wow").gameObject;
        
        if(buddy[0].activeSelf)
        {
            buddy[0].SetActive(false);
            buddy[1].SetActive(true);
            buddyUI.transform.Find("m").gameObject.SetActive(false);
            buddyUI.transform.Find("w").gameObject.SetActive(true);
            buddyBulletSpawner[1].GetComponent<BuddyBulletSpawner>().StartCoroutine(
                buddyBulletSpawner[1].GetComponent<BuddyBulletSpawner>().LongShot(1f,2));
            Debug.Log("good");
        }

        else
        {
            buddy[0].SetActive(true);
            buddy[1].SetActive(false);
            buddyUI.transform.Find("m").gameObject.SetActive(true);
            buddyUI.transform.Find("w").gameObject.SetActive(false);
            buddyBulletSpawner[0].GetComponent<BuddyBulletSpawner>().StartCoroutine(
                buddyBulletSpawner[0].GetComponent<BuddyBulletSpawner>().CloseShot(1f));
            Debug.Log("bad");
        }
        StartCoroutine(tagCoolDown());
    }

    void Dead()
    {
        gameover.SetActive(true);
    }

    IEnumerator tagCoolDown()
    {
        canShoot = false;
        yield return new WaitForSeconds(1.5f);
        canShoot = true;
    }
    
}
