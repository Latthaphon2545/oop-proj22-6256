using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill_Monster : MonoBehaviour
{
    Game_Manager gameMangerScpt;

    private void Start()
    {
        gameMangerScpt = GameObject.FindGameObjectWithTag("GameManager").GetComponent<Game_Manager>();
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameMangerScpt.GameOver();
        }
    }

}
