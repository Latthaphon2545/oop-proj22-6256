using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill_Monster : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Kill Player");
        }
    }

}
