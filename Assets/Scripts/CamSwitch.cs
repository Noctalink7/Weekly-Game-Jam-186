using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour
{
    public Transform Player;
    public GameObject Map1, Map2;
    public KeyCode TKey;
    public bool camSwitch = false;
    public IsGen1 isGen;

    void Start()
    {
        isGen.isGen1 = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(TKey))
        {
            camSwitch = !camSwitch;
            isGen.isGen1 = !isGen.isGen1;
            Map1.gameObject.SetActive(camSwitch);
            Map2.gameObject.SetActive(!camSwitch);
        }
    }
}
