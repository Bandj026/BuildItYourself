using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Whiteboard : MonoBehaviour
{

    private int textureSize = 2048;

    public Texture2D texture;
    
    public void UpdateWhiteboard(Vector3 position, Color penColor, int penSize)
    {
        // convert coords into pixel values
        int x = (int)(position.x * textureSize - (penSize / 2));
        int y = (int)(position.y * textureSize - (penSize / 2));
    }

}
