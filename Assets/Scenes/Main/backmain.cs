using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class backmain : MonoBehaviour
{
    public Button BackMainButton;
    
    // Start is called before the first frame update
    void Start()
    {
        BackMainButton.onClick.AddListener(goToMain);
    }

    // Update is called once per frame
    void goToMain()
    {
        SceneManager.LoadScene("Main");
    }
}
