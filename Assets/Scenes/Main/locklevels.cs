using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class locklevels : MonoBehaviour
{
    public Button[] Level1Button;
    public string numberoflevels;
    ArrayList levels;
    void Start()
    {
        foreach (Button b in Level1Button)
            b.interactable = false;
        

        // levels = new ArrayList(File.ReadAllLines(Application.dataPath + "/levels.txt"));
        // foreach (int i in levels)
        // {
        //     string line = i.ToString();
        //     numberoflevels = i.ToString().Substring(i.ToString().IndexOf(":") + 1);
        // }
        
        int reachedLevel = PlayerPrefs.GetInt("reachedLevel", 9);
        for (int i = 0; i < reachedLevel; i++)
            Level1Button[i].interactable = true;
    }
}
