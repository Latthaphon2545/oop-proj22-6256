using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class divi : MonoBehaviour
{
    public TextMeshProUGUI TextAnswer;
    public TextMeshProUGUI TextT;
    public TextMeshProUGUI TextF1;
    public TextMeshProUGUI TextHealth;
    private int TheNumber1;
    public double Total;
    public TMP_InputField answer;
    public double double_integer_Value_we_Want;
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
            TextAnswer.GetComponent<TextMeshProUGUI> ().text = "" + TheNumber1 + " ÷ " + "2";
            Total = (double)TheNumber1 / 2;
            again = "10";
            next = "11";
        }
        else if (a==2)
        {
            TheNumber1 = Random.Range(10, 101);
            TextAnswer.GetComponent<TextMeshProUGUI> ().text = "" + TheNumber1 + " ÷ " + "2";
            Total = (double)TheNumber1 / 2;
            again = "11";
            next = "12";
        }
        else if (a==3)
        {
            TheNumber1 = Random.Range(100, 1001);
            TextAnswer.GetComponent<TextMeshProUGUI> ().text = "" + TheNumber1 + " ÷ " + "2";
            Total = (double)TheNumber1 / 2;
            again = "12";
            next = "Main";
        }
    }

    public void ChackAnswer()
    {
        if (health == 1)
        {
            IncorrectMenu();
        }

        double_integer_Value_we_Want = double.Parse(answer.text);
        if (double_integer_Value_we_Want == Total)
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