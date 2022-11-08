using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class multiply : MonoBehaviour
{
    public TextMeshProUGUI TextAnswer;
    public TextMeshProUGUI TextT;
    public TextMeshProUGUI TextF1;
    public TextMeshProUGUI TextHealth;
    private int TheNumber1;
    private int TheNumber2;
    private int TheNumber3;
    private int TheNumber4;
    private int Total;
    public TMP_InputField answer;
    public int integer_Value_we_Want;
    public int health=5;
    public static bool Incorrect = false;
    public static bool Correct = false;
    public GameObject IncorrectMenuUI;
    public GameObject CorrectMenuUI;
    public int a;
    private string again;
    private string next;


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            ChackAnswer();
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            RandomGenerate();
        }
    }

    public void RandomGenerate()
    {   
        if (a==1)
        {
            TheNumber1 = Random.Range(1, 11);
            TheNumber2 = Random.Range(1, 11);
            TextAnswer.GetComponent<Text> ().text = "" + TheNumber1 + " x " + TheNumber2;
            Total = TheNumber1 * TheNumber2;
            again = "7";
            next = "8";
        }
        else if (a==2)
        {
            TheNumber1 = Random.Range(1, 11);
            TheNumber2 = Random.Range(1, 11);
            TheNumber3 = Random.Range(1, 11);
            TextAnswer.GetComponent<Text> ().text = "" + TheNumber1 + " x " + TheNumber2 + " x " + TheNumber3;
            Total = TheNumber1 * TheNumber2 * TheNumber3;
            again = "8";
            next = "9";
        }
        else if (a==3)
        {
            TheNumber1 = Random.Range(1, 11);
            TheNumber2 = Random.Range(1, 11);
            TheNumber3 = Random.Range(1, 11);
            TheNumber4 = Random.Range(1, 11);
            TextAnswer.GetComponent<Text> ().text = "" + TheNumber1 + " x " + TheNumber2 + " x " + TheNumber3 + " x " + TheNumber4;
            Total = TheNumber1 * TheNumber2 * TheNumber3 * TheNumber4;
            again = "9";
            next = "10";
        }
    }

    public void ChackAnswer()
    {
        if (health == 1)
        {
            IncorrectMenu();
        }

        integer_Value_we_Want = int.Parse(answer.text);
        if (integer_Value_we_Want == Total)
        {
            TextT.GetComponent<TextMeshProUGUI>().text = "" + "CORRECT";
            CorrectMenu();
        }
        else
        {
            TextF1.GetComponent<TextMeshProUGUI>().text = "" + $"INCORRECT";
            health--;
            TextHealth.GetComponent<TextMeshProUGUI>().text = "" + $"X {health}";
            Invoke("ClearText", 3);
        }
    }

    void ClearText()
    {
        TextT.GetComponent<TextMeshProUGUI>().text = "";
        TextF1.GetComponent<TextMeshProUGUI>().text = "";
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Main");
    }

    public void playagain()
    {
        SceneManager.LoadScene("Level"+again);
    }

    public void NextLevel()
    {
        SceneManager.LoadScene("Level"+next);
    }

    public void IncorrectMenu()
    {
        IncorrectMenuUI.SetActive(true);
        Time.timeScale = 1f;
        Incorrect = true;
    }

    public void CorrectMenu()
    {
        CorrectMenuUI.SetActive(true);
        Time.timeScale = 1f;
        Correct = true;
    }

}