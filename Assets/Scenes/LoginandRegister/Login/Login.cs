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
    public TMP_InputField usernameInput;
    public TMP_InputField passwordInput;
    public Button loginButton;
    public Button goToRegisterButton;

    ArrayList credentials;
    ArrayList adduser;
    // Start is called before the first frame update
    void Start()
    {
        goToRegisterButton.onClick.AddListener(moveToRegister);

        if (File.Exists(Application.dataPath + "/credentials.txt"))
        {
            credentials = new ArrayList(File.ReadAllLines(Application.dataPath + "/credentials.txt"));
        }
        else
        {
            Debug.Log("Credential file doesn't exist");
        }


    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            login();
        }
    }

    // Update is called once per frame
    public void login()
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
            string username_a = usernameInput.text;
            returnusername();
            loadMainScreen();
            // return  usernameInput.text;
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

    void returnusername()
    {
        string path = Application.dataPath + "/adduser.txt";
        File.WriteAllText(path, usernameInput.text);
    }
}
