using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class plus_e : MonoBehaviour
{
    public TextMeshProUGUI TextBox;
    // public GameObject TextBox2;
    public GameObject TextBox2;
    public GameObject TextBox3;
    public TextMeshProUGUI TextBox4;
    public int TheNumber1;
    public int TheNumber2;
    public int TheNumber3;
    public int TheNumber4;
    public int Total;
    public TMP_InputField answer;
    public Button SendAnswerButton;
    public int integer_Value_we_Want;
    
    void Start()
    {
        SendAnswerButton.onClick.AddListener(ChackAnswer);
    }

    public void RandomGenerate(){
        TheNumber1 = Random.Range(1, 11);
        TheNumber2 = Random.Range(1, 11);
        TheNumber3 = Random.Range(1, 11);
        TheNumber4 = Random.Range(1, 11);
        TextBox.GetComponent<TextMeshProUGUI> ().text = "" + TheNumber1 + " + " + TheNumber2 + " + " + TheNumber3 + " + " + TheNumber4;
        Total = TheNumber1 + TheNumber2 + TheNumber3 + TheNumber4;
        // TextBox2.GetComponent<TextMeshProUGUI> ().text = "" + Total;
    }

    public void ChackAnswer()
    {
        integer_Value_we_Want = int.Parse(answer.text);
        if (integer_Value_we_Want == Total)
        {
            TextBox2.GetComponent<Text> ().text = "" + "✓";
            Invoke("ClearText", 3);
        } 
        else
        {
            TextBox3.GetComponent<Text> ().text = "" + $"✘    " ;
            TextBox4.GetComponent<TextMeshProUGUI> ().text = "" + $"{Total}";
            Invoke("ClearText", 3);
        }
    }

    void ClearText()
    {
        TextBox2.GetComponent<Text> ().text = "";
        TextBox3.GetComponent<Text> ().text = "";
        TextBox4.GetComponent<TextMeshProUGUI> ().text = "";
    }
}