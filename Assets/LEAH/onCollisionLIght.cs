using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;

public class onCollisionLIght : MonoBehaviour
{


    Light Awake() {

        Light myLight = GameObject.Find("PointLight").GetComponent<Light>();
        myLight.enabled = false;
        return myLight;
    }

    bool touchCon1 = false;
    bool touchCon2 = false;
    //bool touchCon3 = false;
    //bool touchCon4 = false;

    // Start is called before the first frame update
    void OnTriggerStay(Collider col) 
    { 
        Light myLight = Awake();
        
            if (col.gameObject.name == "Connector1")
            {
                touchCon1 = true;
               // Debug.Log(gameObject.name + "Has collided with" + col.gameObject.name + touchCon2 + touchCon1);
            }

            else if (col.gameObject.name == "Connector2")
            {
                touchCon2 = true;
                //Debug.Log(gameObject.name + "Has collided with" + col.gameObject.name + touchCon2 + touchCon1);
            }

        else
            {
                touchCon1 = false;
                touchCon2 = false;
               // Debug.Log("Not touching");
            }


    }

    void Update() {
        Light myLight = Awake();
     if (touchCon1 == true && touchCon2 == true)
     {
     myLight.enabled = true;
     //Debug.Log("ONE TOUCH!" + touchCon2 + touchCon1);
         }
   }

    void OnTriggerExit(Collider col) {
        Light myLight = Awake();

        
        touchCon1 = false;
        touchCon2 = false;
       // Debug.Log("Not touching!" + touchCon1 + touchCon2);
        myLight.enabled = false;
    }

}
