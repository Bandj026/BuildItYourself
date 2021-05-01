using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Whiteboard : MonoBehaviour
{

    private int textureSize = 2048;

    public Texture2D texture;

    private Material thisWhiteboard;

    private bool touching, touchingLast;

    private float lastX, lastY;

    Vector2 penPosition;
    Color[] penColor;
    int penSize;

    private void Start()
    {
        thisWhiteboard = new Material(Shader.Find("Standard"));
        texture = new Texture2D(textureSize, textureSize);
        // generate a new material with the same properties as the default.
        Renderer renderer = this.GetComponent<Renderer>(); 
        thisWhiteboard.CopyPropertiesFromMaterial(renderer.material);
        renderer.material = thisWhiteboard;
        renderer.material.mainTexture = (Texture) texture;
        
    }

    private void Update()
    {
        // convert coords into pixel values
        int x = (int)(penPosition.x * textureSize - (penSize / 2));
        int y = (int)(penPosition.y * textureSize - (penSize / 2));

        Debug.Log(x + "," + y);

        // Only set the pixels if we were touching last frame
        if (touchingLast)
        {
            // Set base touch pixels
            texture.SetPixels(x, y, penSize, penSize, penColor);

            // Interpolate pixels from previous touch
            for (float t = 0.01f; t < 1.00f; t += 0.01f)
            {
                int lerpX = (int)Mathf.Lerp(lastX, (float)x, t);
                int lerpY = (int)Mathf.Lerp(lastY, (float)y, t);
                texture.SetPixels(lerpX, lerpY, penSize, penSize, penColor);
            }
        }

        // If currently touching, apply the texture
        if (touching)
        {
            texture.Apply();
        }

        this.lastX = (float)x;
        this.lastY = (float)y;

        this.touchingLast = this.touching;
    }

    public void UpdateWhiteboard(Vector2 position, Color[] color, int size)
    {
        penPosition = position;
        penColor = color;
        penSize = size;

        touching = true;
        
    }

}