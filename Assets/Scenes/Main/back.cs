using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class back : MonoBehaviour
{
    public Button BackButton;
    
    // Start is called before the first frame update
    void Start()
    {
        BackButton.onClick.AddListener(goToMain);
    }

    // Update is called once per frame
    void goToMain()
    {
        SceneManager.LoadScene("Main");
    }
}