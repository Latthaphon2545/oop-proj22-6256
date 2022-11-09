using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Register : MonoBehaviour
{
    public GameObject TextBox1;
    public GameObject TextBox2;
    public GameObject TextBox3;
    public GameObject TextBox4;
    public TMP_InputField usernameInput; 
    public TMP_InputField passwordInput;
    public Button registerButton;
    public Button goToLoginButton;
    

    ArrayList credentials;
    ArrayList levels;
    ArrayList adduser;
    // Start is called before the first frame update
    void Start()
    {
        goToLoginButton.onClick.AddListener(goToLoginScene);
        registerButton.onClick.AddListener(writeStuffToFile);

        if (File.Exists(Application.dataPath + "/credentials.txt"))
        {
            credentials = new ArrayList(File.ReadAllLines(Application.dataPath + "/credentials.txt"));
            levels = new ArrayList(File.ReadAllLines(Application.dataPath + "/levels.txt"));
            adduser = new ArrayList(File.ReadAllLines(Application.dataPath + "/adduser.txt"));
        }
        else
        {
            File.WriteAllText(Application.dataPath + "/credentials.txt", "");
        }

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            writeStuffToFile();
        }
    }

    void goToLoginScene()
    {
        SceneManager.LoadScene("Login");
    }


    public void writeStuffToFile()
    {
        bool isExists = false;

        credentials = new ArrayList(File.ReadAllLines(Application.dataPath + "/credentials.txt"));
        foreach (var i in credentials)
        {
            if (i.ToString().Contains(usernameInput.text))
            {
                isExists = true;
                break;
            }
        }


        if (isExists)
        {   
            Debug.Log($"Username '{usernameInput.text}' already exists");
            TextBox3.GetComponent<Text> ().text = "" + "✘";
            TextBox4.GetComponent<Text> ().text = "" + "✘";
            Invoke("ClearText", 3);
        }
        else
        {
            levels = new ArrayList(File.ReadAllLines(Application.dataPath + "/levels.txt"));
            credentials.Add(usernameInput.text + ":" + passwordInput.text);
            levels.Add(usernameInput.text + ":" + 1);
            File.WriteAllLines(Application.dataPath + "/credentials.txt", (String[])credentials.ToArray(typeof(string)));
            File.WriteAllLines(Application.dataPath + "/levels.txt", (String[])levels.ToArray(typeof(string)));
            Debug.Log("Account Registered");
            TextBox1.GetComponent<Text> ().text = "" + "✓";
            TextBox2.GetComponent<Text> ().text = "" + "✓";
            Invoke("ClearText", 3);
        }
    }

    void ClearText()
    {
        TextBox1.GetComponent<Text> ().text = "" + " ";
        TextBox2.GetComponent<Text> ().text = "" + " ";
        TextBox3.GetComponent<Text> ().text = "" + " ";
        TextBox4.GetComponent<Text> ().text = "" + " ";
    }
}
