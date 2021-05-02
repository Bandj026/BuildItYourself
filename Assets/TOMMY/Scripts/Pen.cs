using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Pen : MonoBehaviour
{

    // credit: https://www.youtube.com/watch?v=Rir4A1cr03E
    // used for basic implementation; I added support for multiple pen colours & sizes as well as multiple whiteboards. Also added erasers.
    public int penSize;
    public Color penColor;
    public Color[] color;

    private RaycastHit touchPos;

    public GameObject pos;

    private Whiteboard currentBoard;

    public bool isEraser = false; // used to change raycast direction


    private void OnCollisionEnter(Collision collision)
    {

    }

    private void Update()
    {
        //if (collision.collider.tag == "WritableSurface")
        //{
        // send a raycast out to the whiteboard
        Vector3 dir;

        if(isEraser)
        {
            dir = -transform.up;
        } else
        {
            dir = transform.right;
        }

        if (Physics.Raycast(transform.position, dir, out touchPos, 0.015f))
        {
            if(touchPos.collider.tag == "Whiteboard_Surface")
            {
                //Debug.Log("Hit Surface - " + touchPos.collider.gameObject.name);
                //pos.transform.position = touchPos.point;

                currentBoard = touchPos.collider.GetComponent<Whiteboard>();

                // generate texture blob with correct colour (basically an array of colours, the length of the number of pixels to be drawn)
                color = Enumerable.Repeat(penColor, penSize * penSize).ToArray();

                Debug.Log("Texture Coords: " + touchPos.textureCoord);
                currentBoard.UpdateTouching(true);
                currentBoard.UpdateWhiteboard(touchPos.textureCoord, color, penSize);
            } else
            {
                if(currentBoard != null)
                {
                    currentBoard.UpdateTouching(false);
                    currentBoard = null;
                }
                
            }
            

        } else
        {
            if (currentBoard != null)
            {
                currentBoard.UpdateTouching(false);
                currentBoard = null;
            }
        }
        // collision.gameObject.GetComponent<Whiteboard>().UpdateWhiteboard(this.transform.position,penColor, penSize);
        //}
    }
}
