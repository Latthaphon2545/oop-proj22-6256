using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthbar : MonoBehaviour
{
    [SerializeField] private Image total;
    [SerializeField] private Image now;
    [SerializeField] private health life;

    // Start is called before the first frame update
    void Start()
    {
        total.fillAmount = 1;
        now.fillAmount = 1;
    }

    // Update is called once per frame
    //void Update() => now.fillAmount = life / 5;


}
