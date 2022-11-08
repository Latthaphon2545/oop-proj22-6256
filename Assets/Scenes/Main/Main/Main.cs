using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Main : MonoBehaviour
{
    public Button goToLevelsButton;
    private ArrayList adduser;
    public TextMeshProUGUI TextBox1;
    
    // Start is called before the first frame update
    void Start()
    {
        goToLevelsButton.onClick.AddListener(goToLevelsScene);
        adduser = new ArrayList(File.ReadAllLines(Application.dataPath + "/adduser.txt"));
        string username_a = adduser[0].ToString();
        TextBox1.GetComponent<TextMeshProUGUI>().text = "" + $"{username_a}";

    }

    // Update is called once per frame
    void goToLevelsScene()
    {
        SceneManager.LoadScene("Level");
    }

    public void exit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void goToLoginScene()
    {
        SceneManager.LoadScene("Login");
    }
}
