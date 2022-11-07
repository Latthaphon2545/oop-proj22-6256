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
    private ArrayList adduser;
    private ArrayList levels;
    private string numberoflevels;
    void Start()
    {
        adduser = new ArrayList(File.ReadAllLines(Application.dataPath + "/adduser.txt"));
        string username_a = adduser[0].ToString();
        // string username_a = sn.returnusername();
        foreach (Button b in Level1Button)
            b.interactable = false;


        levels = new ArrayList(File.ReadAllLines(Application.dataPath + "/levels.txt"));
        foreach (var i in levels)
        {
            if (i.ToString().Substring(0, i.ToString().IndexOf(":")).Equals(username_a))
            {
                numberoflevels = i.ToString().Substring(i.ToString().IndexOf(":") + 1);
                break;
            }
        }

        int memeValue;
        int.TryParse(numberoflevels, out memeValue);
        int reachedLevel = PlayerPrefs.GetInt("reachedLevel", memeValue);
        List<int> a =  new List<int>{};
        for (int i = 0; i < reachedLevel; i++)
        {
            Level1Button[i].interactable = true;
            a.Add(i);
        }
    }
}
