using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZone : MonoBehaviour
{
    Game_Manager gameMangerScpt;
    public GameObject Heath1;
    public GameObject Heath2;
    public GameObject Heath3;
    public GameObject Heath4;
    public GameObject Heath5;
    // Start is called before the first frame update
    void Start()
    {

        gameMangerScpt = GameObject.FindGameObjectWithTag("GameManager").GetComponent<Game_Manager>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameMangerScpt.GameOver();
            Heath1.gameObject.SetActive(false);
            Heath2.gameObject.SetActive(false);
            Heath3.gameObject.SetActive(false);
            Heath4.gameObject.SetActive(false);
            Heath5.gameObject.SetActive(false);
        }
    }
}
