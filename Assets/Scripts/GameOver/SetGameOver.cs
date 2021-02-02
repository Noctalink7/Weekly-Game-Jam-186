using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetGameOver : MonoBehaviour
{
    public IsGen1 win;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        if (win.isGen1)
        {
            text.text = "Congratulation You Win !";
        }
        else
        {
            text.text = "You Lost!";
        }
    }
}
