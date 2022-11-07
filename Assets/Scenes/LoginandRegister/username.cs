using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class username : MonoBehaviour
{
    public TMP_InputField usernameInput;
    public string username_old;

    void Start()
    {
        kuy();
    }
    public string kuy()
    {
        username_old = usernameInput.text;
        // Debug.Log("username_old: " + username_old);
        return username_old;
    }
}
