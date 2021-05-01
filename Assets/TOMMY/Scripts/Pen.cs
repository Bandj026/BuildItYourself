using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pen : MonoBehaviour
{

    public int penSize;
    public Color penColor;

    private RaycastHit touchPos;

    public GameObject pos;
    

    private void OnCollisionEnter(Collision collision)
    {

    }

    private void Update()
    {
        //if (collision.collider.tag == "WritableSurface")
        //{
            // send a raycast out to the whiteboard
            if(Physics.Raycast(transform.position, transform.right, out touchPos, 0.01f))
            {
                Debug.Log("Hit Surface - " + touchPos.collider.gameObject.name);
                pos.transform.position = touchPos.point;

            }
           // collision.gameObject.GetComponent<Whiteboard>().UpdateWhiteboard(this.transform.position,penColor, penSize);
        //}
    }
}
