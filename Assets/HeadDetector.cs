using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class HeadDetector : MonoBehaviour
{
    /*bool alreadyRunning = false;

    private Vector3 ogScale;

    Color fadeColor = Color.black;
    Color previousColor = Color.black;

    public MeshRenderer[] renderers;

    private void Start()
    {
        fadeColor.a = 0f;
        previousColor.a = 0f;

        renderers = FindObjectsOfType<MeshRenderer>();

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Planet")
        {
            if(!alreadyRunning)
            {
                ogScale = other.transform.localScale;
               // StartCoroutine(FadeToBlack());
            }
        }
        
        
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Planet")
        {
            var scaleValue = Mathf.Clamp((1/(Vector3.Distance(other.transform.position, transform.position))) * 0.05f, ogScale.x * 1, ogScale.x * 2);
            other.transform.localScale = new Vector3(scaleValue, scaleValue, scaleValue);
            fadeColor.a = Mathf.Clamp(scaleValue * 1024, 0, 255);
            Debug.Log(fadeColor.a);

            foreach (MeshRenderer renderer in renderers)
            {
                Color temp = renderer.material.color;
                temp.a = fadeColor.a;
                renderer.material.color = temp;
            }
            //if(!alreadyRunning)
            //{
                //FadeToColour();
            //}
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Planet")
        {
            other.transform.localScale = ogScale;
            //SteamVR_Fade.Start(Color.black, 0);
            //SteamVR_Fade.Start(Color.clear, 0.3f);
        } 
    }

    IEnumerator FadeToColour()
    {
        alreadyRunning = true;
        SteamVR_Fade.Start(Color.clear, 0);
        SteamVR_Fade.Start(Color.black, 0.1f);
        yield return new WaitForSeconds(0.1f);
        previousColor = fadeColor;
        alreadyRunning = false;
    }*/
}
