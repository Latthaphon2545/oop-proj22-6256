using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicControlScript : MonoBehaviour
{
    public static MusicControlScript instance; 

    private void Awake() 
    {
        DontDestroyOnLoad(this.gameObject); 

        if (instance == null)
        {
            instance = this; 
        }
        else 
        {
            Destroy(gameObject); 
        }
    }
}
