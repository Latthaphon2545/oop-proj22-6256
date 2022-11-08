using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class tap_input : MonoBehaviour
{
    public TMP_InputField usernameInput;
    public TMP_InputField passwordInput;
    public int InputSelected;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab) && Input.GetKeyDown(KeyCode.LeftShift))
        {
            InputSelected--;
            if (InputSelected < 0 ) InputSelected =1;
            SelecInputField();
        }

        else if (Input.GetKeyDown(KeyCode.Tab))
        {
            InputSelected++;
            if (InputSelected > 1 ) InputSelected =0;
            SelecInputField();
        }
 
    }

    void SelecInputField()
    {
        switch (InputSelected)
        {
            case 0: usernameInput.Select();
                break;
            case 1: passwordInput.Select();
                break;
        }
    }

    public void UsernameSeleced() => InputSelected = 0;
    public void PasswordSeleced() => InputSelected = 1;
}
