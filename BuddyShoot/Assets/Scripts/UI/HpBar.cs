using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using Image = UnityEngine.UI.Image;

public class HpBar : MonoBehaviour
{
    GameObject buddy;
    BuddyController player;
    public int maxHelth;
    public int curHelth;
    public Image helthBar;
    public float hp_prop;

    void Start()
    {
        buddy = GameObject.Find("Buddy");
        player = buddy.GetComponent<BuddyController>();
        maxHelth = player.maxHelth;
        curHelth = player.curHelth;
        fillBar();
    }

    // Update is called once per frame
    void Update()
    {
        fillBar();
    }

    private void fillBar()
    {
        hp_prop = (float)player.curHelth/(float)maxHelth;
        helthBar.fillAmount = hp_prop;
    }
}
