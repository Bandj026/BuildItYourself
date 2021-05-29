using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;

public class onCollison2 : MonoBehaviour
{

    Light Awakex()
    {

        Light myLight = GameObject.Find("PointLight").GetComponent<Light>();
        myLight.enabled = false;
        return myLight;
    }

    bool touchCon11 = false;
    bool touchCon22 = false;
    //bool touchCon3 = false;
    //bool touchCon4 = false;

    // Start is called before the first frame update
    void OnTriggerStay(Collider col)
    {
        Light myLight = Awakex();

        if (col.gameObject.name == "Connector1")
        {
            touchCon11 = true;
            // Debug.Log(gameObject.name + "Has collided with" + col.gameObject.name + touchCon2 + touchCon1);
        }

        else if (col.gameObject.name == "Connector2")
        {
            touchCon22 = true;
            //Debug.Log(gameObject.name + "Has collided with" + col.gameObject.name + touchCon2 + touchCon1);
        }

        else
        {
            touchCon11 = false;
            touchCon22 = false;
            // Debug.Log("Not touching");
        }


    }

    void Update()
    {
        Light myLight = Awakex();
        if (touchCon11 == true && touchCon22 == true)
        {
            myLight.enabled = true;
            //Debug.Log("ONE TOUCH!" + touchCon2 + touchCon1);
        }
    }

    void OnTriggerExit(Collider col)
    {
        Light myLight = Awakex();


        touchCon11 = false;
        touchCon22 = false;
        // Debug.Log("Not touching!" + touchCon1 + touchCon2);
        myLight.enabled = false;
    }

}

