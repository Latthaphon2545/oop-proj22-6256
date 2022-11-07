using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour
{
    public float nowHealth;
    [SerializeField] float startedHealth;

    // Start is called before the first frame update
    void Start()
    {
        nowHealth = startedHealth;
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.E))
        //{
        //    damage();
        //}
    }


    private void damage()
    {
        if (Input.GetKey(KeyCode.E))
        {
            nowHealth = nowHealth - 1;

            if (nowHealth > 0)
            {
                //hurt
            }
            else
            {
                //dead
            }
        }
    }

}
