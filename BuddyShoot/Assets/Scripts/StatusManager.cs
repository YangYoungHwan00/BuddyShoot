using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class StatusManager : MonoBehaviour
{
    // Stat stat = new Stat(10f, 10f, 10f);
    // string json = JsonUtility.ToJson(stat);
    // string filePath = Application.persistentDataPath + "/stat.json";
    string filePath = "Assets/Data" + "/stat.json";
    Stat stat;

    public void SaveData()
    {
    	// myObject에는 위 예시 userData와 같은 object가 들어갑니다.
        stat = new Stat(10,20,30);
        string jsonStr = JsonUtility.ToJson(stat);
        File.WriteAllText(filePath, jsonStr);
        Debug.Log($"Save Completed : {filePath}");
    }

    public void ReadData()
    {
        var loadedData = File.ReadAllText(filePath);
        Stat myStat = JsonUtility.FromJson<Stat>(loadedData.ToString());
        Debug.Log(myStat.Atk);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.L))
        {
            SaveData();
            Debug.Log("ggod");
        }
        if(Input.GetKeyDown(KeyCode.J))
        {
            ReadData();
        }
    }
}
