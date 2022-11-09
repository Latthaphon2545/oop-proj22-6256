using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class end : MonoBehaviour
{
    public Button goToMainButton;
    private float timer = 11;

    // Start is called before the first frame update
    void Start()
    {
        goToMainButton.onClick.AddListener(goToMainScene);
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            SceneManager.LoadScene("Main");
        }
    }

    void goToMainScene()
    {
        SceneManager.LoadScene("Main");
    }

    
}
