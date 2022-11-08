using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class plus : MonoBehaviour
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
    private ArrayList adduser;
    private ArrayList read_levels;
    private string numberoflevels;



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
            TheNumber1 = UnityEngine.Random.Range(1, 11);
            TheNumber2 = UnityEngine.Random.Range(1, 11);
            TheNumber3 = UnityEngine.Random.Range(1, 11);
            TheNumber4 = UnityEngine.Random.Range(1, 11);
            TextAnswer.GetComponent<TextMeshProUGUI>().text = "" + TheNumber1 + " + " + TheNumber2 + " + " + TheNumber3 + " + " + TheNumber4;
            Total = TheNumber1 + TheNumber2 + TheNumber3 + TheNumber4;
            again = "1";
            next = "2";
        }
        else if (a==2)
        {
            TheNumber1 = UnityEngine.Random.Range(10, 101);
            TheNumber2 = UnityEngine.Random.Range(10, 101);
            TheNumber3 = UnityEngine.Random.Range(10, 101);
            TextAnswer.GetComponent<TextMeshProUGUI>().text = "" + TheNumber1 + " + " + TheNumber2 + " + " + TheNumber3;
            Total = TheNumber1 + TheNumber2 + TheNumber3;
            again = "2";
            next = "3";
        }
        else if (a==3)
        {
            TheNumber1 = UnityEngine.Random.Range(100, 1001);
            TheNumber2 = UnityEngine.Random.Range(100, 1001);
            TextAnswer.GetComponent<TextMeshProUGUI>().text = "" + TheNumber1 + " + " + TheNumber2;
            Total = TheNumber1 + TheNumber2;
            again = "3";
            next = "4";
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
            writeStuffToFile();
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

    public void writeStuffToFile()
    {
        adduser = new ArrayList(File.ReadAllLines(Application.dataPath + "/adduser.txt"));
        string username_a = adduser[0].ToString();
        read_levels = new ArrayList(File.ReadAllLines(Application.dataPath + "/levels.txt"));
        List<int> list1 = new List<int>();
        foreach (var i in read_levels)
        {
            if (i.ToString().Substring(0, i.ToString().IndexOf(":")).Equals(username_a))
            {
                numberoflevels = i.ToString().Substring(i.ToString().IndexOf(":") + 1);
                int numberoflevel;
                int.TryParse(numberoflevels, out numberoflevel);
                numberoflevel++;
                list1.Add(numberoflevel); 
            }
        }
        list1.Sort();
        list1.Reverse();
        string new_levels = username_a + ":" + list1[0];
        read_levels.Add(new_levels);
        File.WriteAllLines(Application.dataPath + "/levels.txt", (String[])read_levels.ToArray(typeof(string)));
    }
}