using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heath : MonoBehaviour
{
    public GameObject Heath1;
    public GameObject Heath2;
    public GameObject Heath3;
    public GameObject Heath4;
    public GameObject Heath5;

    public int health=5;
    Kill_Monster monster;

    // Start is called before the first frame update
    void Start()
    {
        monster = GameObject.FindObjectOfType<Kill_Monster>();
    }

    // Update is called once per frame
    public void GetHit(int damage) 
    {
        health = health - damage;
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
        {   Heath1.gameObject.SetActive(true);
            Heath2.gameObject.SetActive(true);
            Heath2.gameObject.SetActive(true);
            Heath4.gameObject.SetActive(false);
            Heath5.gameObject.SetActive(false);
        }
        else if (health == 2)
        {   Heath1.gameObject.SetActive(true);
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
        else if (health == 0)
        {
            Heath1.gameObject.SetActive(false);
            Heath2.gameObject.SetActive(false);
            Heath3.gameObject.SetActive(false);
            Heath4.gameObject.SetActive(false);
            Heath5.gameObject.SetActive(false);
        }
    }
}
