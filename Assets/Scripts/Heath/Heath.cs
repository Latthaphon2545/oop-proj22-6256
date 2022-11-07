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

    int health;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            health --;

        }

        if (Input.GetKey(KeyCode.E))
        {
            health ++;

        }
        switch (health)
        {
            case 0:
                {
                    Heath1.gameObject.SetActive(false);
                    Heath2.gameObject.SetActive(false);
                    Heath3.gameObject.SetActive(false);
                    Heath4.gameObject.SetActive(false);
                    Heath5.gameObject.SetActive(false);
                    break;
                }
            case 1:
                {
                    Heath1.gameObject.SetActive(true);
                    Heath2.gameObject.SetActive(false);
                    Heath3.gameObject.SetActive(false);
                    Heath4.gameObject.SetActive(false);
                    Heath5.gameObject.SetActive(false);
                    break;
                }
            case 2:
                {
                    Heath1.gameObject.SetActive(true);
                    Heath2.gameObject.SetActive(true);
                    Heath3.gameObject.SetActive(false);
                    Heath4.gameObject.SetActive(false);
                    Heath5.gameObject.SetActive(false);
                    break;
                }
            case 3:
                {
                    Heath1.gameObject.SetActive(true);
                    Heath2.gameObject.SetActive(true);
                    Heath3.gameObject.SetActive(true);
                    Heath4.gameObject.SetActive(false);
                    Heath5.gameObject.SetActive(false);
                    break;
                }
            case 4:
                {
                    Heath1.gameObject.SetActive(true);
                    Heath2.gameObject.SetActive(true);
                    Heath3.gameObject.SetActive(true);
                    Heath4.gameObject.SetActive(true);
                    Heath5.gameObject.SetActive(false);
                    break;
                }
            case 5:
                {
                    Heath1.gameObject.SetActive(true);
                    Heath2.gameObject.SetActive(true);
                    Heath3.gameObject.SetActive(true);
                    Heath4.gameObject.SetActive(true);
                    Heath5.gameObject.SetActive(true);
                    break;
                }
        }
    }
}
