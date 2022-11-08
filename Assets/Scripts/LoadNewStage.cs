using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewStage : MonoBehaviour
{
    //public string namelevels;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            LoadStage();
        }

    }
    private void LoadStage()
    {
        SceneManager.LoadScene("e_PLUS");//change("เปลี่ยนเป็นที่ต่อไปที่อยากไป")

    }

}
