using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill_Monster : MonoBehaviour
{
    Game_Manager gameMangerScpt;
    Heath PlayerHealth;


    private void Start()
    {
        gameMangerScpt = GameObject.FindGameObjectWithTag("GameManager").GetComponent<Game_Manager>();
        PlayerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<Heath>();
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<Heath>().GetHit(1);
            Destroy(gameObject);
        }
    }

}
