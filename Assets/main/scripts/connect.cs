using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class connect : MonoBehaviour
{
    public int objectNum;
    public int objectNumConnect;

    public bool active;

    public GameObject parent;

    public GameObject createObject;
    public Transform spawnPoint;


    private void OnTriggerEnter(Collider other)
    {
        if (active)
        {
            active = false;
            if (other.gameObject.tag == "ConnectObject" && other.gameObject.transform.parent.gameObject.GetComponent<connect>().objectNum == objectNumConnect)
            {
                if (other.GetComponent<bone>().Bone)
                {
                    Instantiate(createObject, new Vector3(spawnPoint.position.x, spawnPoint.position.y, spawnPoint.position.z), Quaternion.identity);
                    Destroy(other.transform.parent.gameObject);
                    Destroy(gameObject);
                }
            }
        }
    }



}
