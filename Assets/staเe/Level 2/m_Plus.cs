using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class m_Plus : MonoBehaviour
{
    public TextMeshProUGUI TextAnswer;
    public TextMeshProUGUI TextT;
    public TextMeshProUGUI TextF1;
    public TextMeshProUGUI TextHealth;
    private int TheNumber1;
    private int TheNumber2;
    private int TheNumber3;
    private int Total;
    public TMP_InputField answer;
    public int integer_Value_we_Want;
    public int health=5;
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;


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
        TheNumber1 = Random.Range(10, 101);
        TheNumber2 = Random.Range(10, 101);
        TheNumber3 = Random.Range(10, 101);
        TextAnswer.GetComponent<TextMeshProUGUI>().text = "" + TheNumber1 + " + " + TheNumber2 + " + " + TheNumber3;
        Total = TheNumber1 + TheNumber2 + TheNumber3;
    }

    public void ChackAnswer()
    {
        if (health == 1)
        {
            pauseMenuUI.SetActive(true);
            Time.timeScale = 1f;
            GameIsPaused = true;
        }

        integer_Value_we_Want = int.Parse(answer.text);
        if (integer_Value_we_Want == Total)
        {
            TextT.GetComponent<TextMeshProUGUI>().text = "" + "CORRECT";
            Invoke("ClearText", 3);
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
        SceneManager.LoadScene("Level2");
    }

}