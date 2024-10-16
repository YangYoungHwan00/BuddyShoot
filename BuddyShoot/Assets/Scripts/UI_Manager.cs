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

    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void OpenStage()
    {
        something.SetActive(true);
    }

    public void CloseStage()
    {
        something.SetActive(false);
    }

    public void GotoStage1()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void OpenUpgrade()
    {
        something.SetActive(true);
    }
    
    public void CloseUpgrade()
    {
        something.SetActive(false);
    }
}
