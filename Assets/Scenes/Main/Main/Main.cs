using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    public Button goToLevelsButton;
    
    // Start is called before the first frame update
    void Start()
    {
        goToLevelsButton.onClick.AddListener(goToLevelsScene);
    }

    // Update is called once per frame
    void goToLevelsScene()
    {
        SceneManager.LoadScene("Level");
    }
}
