using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class intro : MonoBehaviour
{
    public Button goToLoginButton;
    private float timer = 16;

    // Start is called before the first frame update
    void Start()
    {
        goToLoginButton.onClick.AddListener(goToLoginScene);
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            SceneManager.LoadScene("Login");
        }
    }

    void goToLoginScene()
    {
        SceneManager.LoadScene("Login");
    }

    
}
