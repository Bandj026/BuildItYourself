using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class col3 : MonoBehaviour
{
    //bool touchCon4 = false;

    Light Awake()
    {

        Light myLight = GameObject.Find("SpotLight2").GetComponent<Light>();
        myLight.enabled = false;
        return myLight;
    }



    void OnTriggerStay(Collider col)
    {
        Light myLight = Awake();

        if (col.gameObject.name == "Block1" || col.gameObject.name == "Block2")
        {
            myLight.enabled = true;
            Debug.Log("TOUCHINGB");

        }
        else
        {
            //touchCon4 = false; 
            myLight.enabled = false;
            Debug.Log("NOT TOUCHINGB");
        }
    }




    void OnTriggerExit(Collider col)
    {
        Light myLight = Awake();

        //touchCon4 = false;
        myLight.enabled = false;
        Debug.Log("NOT TOUCHING");
    }




}
