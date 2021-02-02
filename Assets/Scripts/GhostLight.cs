using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostLight : MonoBehaviour
{
    public GameObject ghostLight;
    public Transform transform;

    void Update()
    {
        ghostLight.gameObject.transform.position = transform.position;
    }
}
