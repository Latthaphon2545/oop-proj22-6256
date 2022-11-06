using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour
{
    //public float nowHealth;
    //[SerializeField] float startedHealth;

    //// Start is called before the first frame update
    //void Start()
    //{
    //    nowHealth = startedHealth;
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    //if (Input.GetKey(KeyCode.E))
    //    //{
    //    //    damage();
    //    //}
    //}


    //private void damage()
    //{
    //    if (Input.GetKey(KeyCode.E))
    //    {
    //        nowHealth = nowHealth - 1;

    //        if (nowHealth > 0)
    //        {
    //            //hurt
    //        }
    //        else
    //        {
    //            //dead
    //        }
    //    }
    //}
    public static int healthh = 5;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    void Awake()
    {
        healthh = 5;
    }
    // Update is called once per frame
    void Update()
    {
        foreach (Image img in hearts)
        {
            img.sprite = emptyHeart;
        }
        for (int i = 0; i < healthh; i++)
        {
            hearts[i].sprite = fullHeart;
        }
    }
}
