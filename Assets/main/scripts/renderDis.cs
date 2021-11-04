using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class renderDis : MonoBehaviour
{
    private void Start()
    {
        gameObject.GetComponent<Renderer>().enabled = false;
    }
}
