using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class plus_h : MonoBehaviour
{
    public GameObject TextBox;
    public GameObject TextBox2;
    public GameObject TextBox3;
    public int TheNumber1;
    public int TheNumber2;
    public int Total;
    public InputField answer;
    public Button SendAnswerButton;
    public int integer_Value_we_Want;
    
    void Start()
    {
        SendAnswerButton.onClick.AddListener(ChackAnswer);
    }

    public void RandomGenerate(){
        TheNumber1 = Random.Range(100, 1000);
        TheNumber2 = Random.Range(100, 1000);

        TextBox.GetComponent<Text> ().text = "" + TheNumber1 + " + " + TheNumber2 ;
        Total = TheNumber1 + TheNumber2 ;
        TextBox2.GetComponent<Text> ().text = "" + Total;
    }

    public void ChackAnswer()
    {
        integer_Value_we_Want = int.Parse(answer.text);
        if (integer_Value_we_Want == Total)
        {
            TextBox3.GetComponent<Text> ().text = "" + " T ";
            SceneManager.LoadScene("Main");
        } 
        else
        {
            TextBox3.GetComponent<Text> ().text = "" + " F ";
        }
    }
}