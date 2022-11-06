using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Login : MonoBehaviour
{
    public GameObject TextBox1;
    public GameObject TextBox2;
    public GameObject TextBox3;
    public TMP_InputField usernameInput;
    public TMP_InputField passwordInput;
    public Button loginButton;
    public Button goToRegisterButton;

    ArrayList credentials;
    // Start is called before the first frame update
    void Start()
    {
        loginButton.onClick.AddListener(login);
        goToRegisterButton.onClick.AddListener(moveToRegister);
        Debug.Log(Username());

        if (File.Exists(Application.dataPath + "/credentials.txt"))
        {
            credentials = new ArrayList(File.ReadAllLines(Application.dataPath + "/credentials.txt"));
        }
        else
        {
            Debug.Log("Credential file doesn't exist");
        }


    }

    // Update is called once per frame
    void login()
    {
        bool isExists = false;

        credentials = new ArrayList(File.ReadAllLines(Application.dataPath + "/credentials.txt"));
        foreach (var i in credentials)
        {
            string line = i.ToString();
            if (i.ToString().Substring(0, i.ToString().IndexOf(":")).Equals(usernameInput.text) &&
                i.ToString().Substring(i.ToString().IndexOf(":") + 1).Equals(passwordInput.text))
            {
                isExists = true;
                break;
            }
        }

        if (isExists)
        {
            Debug.Log($"Logging in '{usernameInput.text}'");
            TextBox3.GetComponent<Text>().text = $"{usernameInput.text}";
            // loadMainScreen();
        }
        else
        {
            Debug.Log("Incorrect credentials");
            TextBox1.GetComponent<Text>().text = "" + "✘";
            TextBox2.GetComponent<Text>().text = "" + "✘";
            Invoke("ClearText", 3);
        }
    }
    void ClearText()
    {
        TextBox1.GetComponent<Text>().text = "" + "";
        TextBox2.GetComponent<Text>().text = "" + "";
    }

    void moveToRegister()
    {
        SceneManager.LoadScene("Register");
    }

    void loadMainScreen()
    {
        SceneManager.LoadScene("Main");
    }

    public string Username()
    {
        return usernameInput.text;
    }

}
