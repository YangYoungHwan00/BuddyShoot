using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Manager : MonoBehaviour
{
[SerializeField]
    private UnityEngine.UI.Slider hpBar;
    private GameObject buddyController;
    
    void Start()
    {
        buddyController = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
