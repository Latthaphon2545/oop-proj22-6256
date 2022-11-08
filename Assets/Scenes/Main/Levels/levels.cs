using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class levels : MonoBehaviour
{
    public TextMeshProUGUI LevelText;
    public Button Level1Button;
    
    // Start is called before the first frame update
    void Start()
    {
        Level1Button.onClick.AddListener(OpenScene);
    }

    // Update is called once per frame

    void  OpenScene()
    {
        string sceneName = LevelText.text;
        SceneManager.LoadScene("Level" + sceneName);
    }
}
