using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class main : MonoBehaviour
{
    public Button goToLevelsButton;
    public Button goToHowtoplayButton;
    public Button goToControlsButton;
    
    // Start is called before the first frame update
    void Start()
    {
        goToLevelsButton.onClick.AddListener(goToLevelsScene);
        goToHowtoplayButton.onClick.AddListener(goToHowtoplay);
        goToControlsButton.onClick.AddListener(goToControls);
    }

    // Update is called once per frame
    void goToLevelsScene()
    {
        SceneManager.LoadScene("Level");
    }

    void goToHowtoplay()
    {
        SceneManager.LoadScene("Howtoplay");
    }

    void goToControls()
    {
        SceneManager.LoadScene("Controls");
    }

}
