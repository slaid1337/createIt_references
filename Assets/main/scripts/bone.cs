using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bone : MonoBehaviour
{

    public bool Bone;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ConnectObject")
        {
            Bone = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Bone = false;
    }
}
