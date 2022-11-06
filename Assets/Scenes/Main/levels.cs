using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class levels : MonoBehaviour
{
    public Button BackLevelsButton;
    
    // Start is called before the first frame update
    void Start()
    {
        BackLevelsButton.onClick.AddListener(goToLevels);
    }

    // Update is called once per frame
    void goToLevels()
    {
        SceneManager.LoadScene("Level");
    }
}
