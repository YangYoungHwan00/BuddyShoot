using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusManager : MonoBehaviour
{
    private string maxHelthKey = "MaxHelth";
    private string curHelthKey = "CurrentHelth";
    private string atkKey = "AttakPoint";
    private string defKey = "DeffensePoint";
    public int maxHelth;
    public int curHelth;
    public int atk;
    public int def;
    // Start is called before the first frame update
    void Start()
    {
        // if(!PlayerPrefs.HasKey(maxHelthKey))
        //     InitializeStatus();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InitializeStatus(string ObjectID)
    {
        PlayerPrefs.SetInt(ObjectID+maxHelthKey,100);
        PlayerPrefs.SetInt(ObjectID+curHelthKey,100);
        PlayerPrefs.SetInt(ObjectID+atkKey,10);
        PlayerPrefs.SetInt(ObjectID+defKey,10);
        PlayerPrefs.Save();
    }

    public void saveStatus(string ObjectID)
    {
        PlayerPrefs.SetInt(ObjectID+maxHelthKey,maxHelth);
        PlayerPrefs.SetInt(ObjectID+curHelthKey,curHelth);
        PlayerPrefs.SetInt(ObjectID+atkKey,atk);
        PlayerPrefs.SetInt(ObjectID+defKey,def);
    }

    public int[] loadStatus(string ObjectID)
    {
        int[] a= new int[4];
        maxHelth = PlayerPrefs.GetInt(ObjectID+maxHelthKey);
        curHelth = PlayerPrefs.GetInt(ObjectID+curHelthKey);
        atk = PlayerPrefs.GetInt(ObjectID+atkKey);
        def = PlayerPrefs.GetInt(ObjectID+defKey);
        a[0] = maxHelth;
        a[1] = curHelth;
        a[2] = atk;
        a[3] = def;
        return a;
    }
}
