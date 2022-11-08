using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class die : MonoBehaviour
{
    public GameObject IncorrectMenuUI;
    public void IncorrectMenu()
    {
        IncorrectMenuUI.SetActive(true);
        Time.timeScale = 1f;
        Incorrect = true;
    }
}
