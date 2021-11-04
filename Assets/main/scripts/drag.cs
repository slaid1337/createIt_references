using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drag : MonoBehaviour
{
    private Vector3 mOffset;
    public bool draggable;
    public bool collision;

    private float mZCoord;

    private void Awake()
    {
        draggable = true;
        collision = true;
    }

    void OnMouseDown()

    {
        if (draggable)
        {

            mZCoord = Camera.main.WorldToScreenPoint(

                gameObject.transform.position).z;



            // Store offset = gameobject world pos - mouse world pos

            mOffset = gameObject.transform.position - GetMouseAsWorldPoint();

            gameObject.GetComponent<connect>().active = true;

        }
    }

    private void OnMouseUp()
    {
        Invoke("activeDis", 1f);
    }

    private Vector3 GetMouseAsWorldPoint()

    {
        

            // Pixel coordinates of mouse (x,y)

            Vector3 mousePoint = Input.mousePosition;



            // z coordinate of game object on screen

            mousePoint.z = mZCoord;



            // Convert it to world points

            return Camera.main.ScreenToWorldPoint(mousePoint);
        

    }



    void OnMouseDrag()

    {
        if (draggable && collision)
        {
            
            transform.position = GetMouseAsWorldPoint() + mOffset + new Vector3(0,0.2f,0);

        }
    }
    

    private void activeDis()
    {
        gameObject.GetComponent<connect>().active = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "wall")
        {
            collision = false;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "wall")
        {
            collision = true;
        }
    }

}
