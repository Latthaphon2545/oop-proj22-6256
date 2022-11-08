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
        foreach (Button b in Level1Button)
            b.interactable = false;

        List<int> list1 = new List<int>();
        levels = new ArrayList(File.ReadAllLines(Application.dataPath + "/levels.txt"));
        foreach (var i in levels)
        {
            if (i.ToString().Substring(0, i.ToString().IndexOf(":")).Equals(username_a))
            {
                numberoflevels = i.ToString().Substring(i.ToString().IndexOf(":") + 1);
                int numberoflevel;
                int.TryParse(numberoflevels, out numberoflevel);
                list1.Add(numberoflevel);    
            }
        }

        list1.Sort();
        list1.Reverse();
        int Maxlevel = list1[0];
        int reachedLevel = PlayerPrefs.GetInt("reachedLevel", Maxlevel);
        List<int> a =  new List<int>{};
        for (int i = 0; i < reachedLevel; i++)
        {
            Level1Button[i].interactable = true;
            a.Add(i);
        }
    }
}
