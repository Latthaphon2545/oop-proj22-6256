using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class plus_m : MonoBehaviour
{
    public GameObject TextBox;
    public GameObject TextBox2;
    public GameObject TextBox3;
    public int TheNumber1;
    public int TheNumber2;
    public int TheNumber3;
    public int Total;
    public InputField answer;
    public Button SendAnswerButton;
    public int integer_Value_we_Want;
    
    void Start()
    {
        SendAnswerButton.onClick.AddListener(ChackAnswer);
    }

    public void RandomGenerate(){
        TheNumber1 = Random.Range(10, 101);
        TheNumber2 = Random.Range(10, 101);
        TheNumber3 = Random.Range(10, 101);
        TextBox.GetComponent<Text> ().text = "" + TheNumber1 + " + " + TheNumber2 + " + " + TheNumber3 ;
        Total = TheNumber1 + TheNumber2 + TheNumber3 ;
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