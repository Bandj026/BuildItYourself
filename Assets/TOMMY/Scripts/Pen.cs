using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Pen : MonoBehaviour
{

    public int penSize;
    public Color penColor;
    public Color[] color;

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
        if (Physics.Raycast(transform.position, transform.right, out touchPos, 0.01f))
        {
            if(touchPos.collider.tag == "Whiteboard_Surface")
            {
                //Debug.Log("Hit Surface - " + touchPos.collider.gameObject.name);
                //pos.transform.position = touchPos.point;

                Whiteboard board = touchPos.collider.GetComponent<Whiteboard>();

                // generate texture blob with correct colour (basically an array of colours, the length of the number of pixels to be drawn)
                color = Enumerable.Repeat(penColor, penSize * penSize).ToArray();

                Debug.Log("Texture Coords: " + touchPos.textureCoord);

                board.UpdateWhiteboard(touchPos.textureCoord, color, penSize);
            }
            

        }
        // collision.gameObject.GetComponent<Whiteboard>().UpdateWhiteboard(this.transform.position,penColor, penSize);
        //}
    }
}
