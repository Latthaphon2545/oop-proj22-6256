using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class plus_e : MonoBehaviour
{
    public TextMeshProUGUI TextBox1;
    // public GameObject TextBox2;
    public GameObject TextBox2;
    public GameObject TextBox3;
    public TextMeshProUGUI TextBox4;
    private int TheNumber1;
    private int TheNumber2;
    private int TheNumber3;
    private int TheNumber4;
    private int Total;
    public TMP_InputField answer;
    public Button SendAnswerButton;
    public int integer_Value_we_Want;
    public GameObject Heath1;
    public GameObject Heath2;
    public GameObject Heath3;
    public GameObject Heath4;
    public GameObject Heath5;
    [SerializeField] private int health;

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
        TheNumber1 = Random.Range(1, 11);
        TheNumber2 = Random.Range(1, 11);
        TheNumber3 = Random.Range(1, 11);
        TheNumber4 = Random.Range(1, 11);
        TextBox1.GetComponent<TextMeshProUGUI>().text = "" + TheNumber1 + " + " + TheNumber2 + " + " + TheNumber3 + " + " + TheNumber4;
        Total = TheNumber1 + TheNumber2 + TheNumber3 + TheNumber4;
        // TextBox2.GetComponent<TextMeshProUGUI> ().text = "" + Total;
    }

    public void ChackAnswer()
    {
        integer_Value_we_Want = int.Parse(answer.text);
        if (integer_Value_we_Want == Total)
        {
            TextBox2.GetComponent<Text>().text = "" + "✓";
            Invoke("ClearText", 3);
        }
        else
        {
            TextBox3.GetComponent<Text>().text = "" + $"✘    ";
            TextBox4.GetComponent<TextMeshProUGUI>().text = "" + $"{Total}";
            int x = 1;
            health = health - x;
            // show_heart(health);
            Invoke("ClearText", 3);
        }
    }

    void ClearText()
    {
        TextBox2.GetComponent<Text>().text = "";
        TextBox3.GetComponent<Text>().text = "";
        TextBox4.GetComponent<TextMeshProUGUI>().text = "";
    }

    void show_heart(int health)
    {
        if (health == 5)
        {
            Heath1.gameObject.SetActive(true);
            Heath2.gameObject.SetActive(true);
            Heath3.gameObject.SetActive(true);
            Heath4.gameObject.SetActive(true);
            Heath5.gameObject.SetActive(true);
        }
        else if (health == 4)
        {
            Heath1.gameObject.SetActive(true);
            Heath2.gameObject.SetActive(true);
            Heath3.gameObject.SetActive(true);
            Heath4.gameObject.SetActive(true);
            Heath5.gameObject.SetActive(false);
        }
        else if (health == 3)
        {
            Heath1.gameObject.SetActive(true);
            Heath2.gameObject.SetActive(true);
            Heath3.gameObject.SetActive(true);
            Heath4.gameObject.SetActive(false);
            Heath5.gameObject.SetActive(false);
        }
        else if (health == 2)
        {
            Heath1.gameObject.SetActive(true);
            Heath2.gameObject.SetActive(true);
            Heath3.gameObject.SetActive(false);
            Heath4.gameObject.SetActive(false);
            Heath5.gameObject.SetActive(false);
        }
        else if (health == 1)
        {
            Heath1.gameObject.SetActive(true);
            Heath2.gameObject.SetActive(false);
            Heath3.gameObject.SetActive(false);
            Heath4.gameObject.SetActive(false);
            Heath5.gameObject.SetActive(false);
        }
        else
        {
            Heath1.gameObject.SetActive(false);
            Heath2.gameObject.SetActive(false);
            Heath3.gameObject.SetActive(false);
            Heath4.gameObject.SetActive(false);
            Heath5.gameObject.SetActive(false);

        }
    }
}