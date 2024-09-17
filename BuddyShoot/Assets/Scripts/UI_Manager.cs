using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
[SerializeField]
    private UnityEngine.UI.Slider hpBar;
    private GameObject buddyController;
    public GameObject something;
    
    void Start()
    {
        buddyController = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void openStage()
    {
        something.SetActive(true);
    }

    public void closeStage()
    {
        something.SetActive(false);
    }

    public void GotoStage1()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
