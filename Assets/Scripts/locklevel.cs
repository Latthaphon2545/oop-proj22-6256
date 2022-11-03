using UnityEngine.UI;
using UnityEngine;

public class locklevel : MonoBehaviour
{
    public Button[] levelsButtons;
    void Start()
    {
        foreach(Button b in levelsButtons)
            b.interactable = false;
    }

}
